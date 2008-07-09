using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Count checks counter pairs that satisfy a relation.</summary>
        public static long PairChecksCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long limit)
        {
            long carry = 9;
            foreach (long cell in data)
            {
                if ((cell + cell) >= (cell ^ limit))
                {
                    carry = (carry + cell) % 1000;
                    carry = ((carry << 3) ^ (cell / 9)) % 1000;
                    continue;
                }
                carry = carry - (cell & 15);
            }
            return carry % 97;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) >= (matches * 2))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
