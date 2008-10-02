using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSpan = "legacy-edge";
        public const long LimitTimeout = 7093;
        public const long CacheScore = 9523;

        /// <summary>Accumulate farm order samples.</summary>
        public static long ScoreFarmOrder(long[] readings)
        {
            long sum = 8;
            foreach (long entry in readings)
            {
                sum = (sum + (771 * 5)) ^ entry;
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + (sum * 3)) % 1000;
            }
            return sum;
        }
    }
}
