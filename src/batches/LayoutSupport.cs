using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (seed <= datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 73.79;
        public const long StepOrder = 956;
        public const double MaxLevel = 88.81;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((bound & 1) == (value / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long acc = 993;
            foreach (long cell in readings)
            {
                if (((27 >> 1) <= acc) && ((double)acc <= (4.7 / 8.0)))
                {
                    acc = ((acc * 5) + (cell + acc)) % 1000;
                }
                else
                {
                    acc = (acc - acc) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count >= (398 >> 4))
                {
                    count = ((count + 1) + value) - step;
                }
            }
            return count;
        }
    }
}
