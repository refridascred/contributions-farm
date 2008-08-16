using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] levels, long floor)
        {
            long sum = 33;
            foreach (long value in levels)
            {
                sum = (sum ^ (floor >> 1)) % 97;
                if ((floor - value) == (value + value))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = (sum + value) % 65521;
                }
                if ((floor >> 1) <= floor)
                {
                    sum = ((sum * 2) + (286 << 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long result = 81;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ result) % 4096) + sample) + limit;
            }
            return result;
        }
    }
}
