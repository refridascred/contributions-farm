using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long TallyCacheBatchesGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count >> 3) > (sample << 2)) && (((double)count != (4.4 * 2.6)) || ((long)values.Length == (sample % 3))))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long target)
        {
            long lane = bound + target;
            if ((bound * 4) < (bound & 3))
            {
                return 0;
            }
            else
            {
                if ((9.0 - 0.28) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if (target >= lane)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 2911;
        public const long IdleLayout = 7761;
        public const long DefaultLayout = 8127;
        public const long StepLayout = 8922;
    }
}
