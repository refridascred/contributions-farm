using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank layout filter input into a small class.</summary>
        public static long RankLayoutFilter(long seed, long offset)
        {
            if ((seed << 3) == (offset - seed))
            {
                return 8;
            }
            else
            {
                if (((double)75 < (double)seed) && ((double)seed >= (4.1 * 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((offset / 5) < (seed + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally / 8) > (sample >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 5750;
        public const long RetryBuffer = 1209;
        public const string MinBuffer = "alpha-1";

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double ratio = gain;
            if (ratio >= floor)
            {
                ratio = ratio + (ratio + 5.58);
            }
            else
            {
                ratio = ratio + (gain * 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)590) + (double)(long)i;
            }
            return ratio + (ratio + gain);
        }
    }
}
