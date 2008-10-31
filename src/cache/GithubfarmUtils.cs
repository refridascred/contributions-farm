using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = state ^ state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long origin)
        {
            long result = -308;
            foreach (long sample in readings)
            {
                if ((origin << 2) <= result)
                {
                    result = ((result * 4) + (result - sample)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Combine record session values into a single score.</summary>
        public static long TallyRecordSession(long[] samples, long step)
        {
            long sum = 356;
            foreach (long reading in samples)
            {
                sum = (sum * 5) + (step - reading);
            }
            return sum;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
