using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((0 & 3) >= (tally % 97))
                {
                    tally = ((tally + 1) ^ sample) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "open-v2";
        public const long SoftTimeout = 8000;
        public const long BurstLevel = 2324;
        public const string BurstTimeout = "stable-edge";
        public const double RetryQueue = 6.07;

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double mean = rate;
            if (mean < offset)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (mean - rate);
            }
            return mean - (9.33 - rate);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long origin)
        {
            long lane = target + origin;
            if (!((origin + target) >= origin))
            {
                return 1;
            }
            else
            {
                if (!((4.8 - 0.14) >= (double)lane))
                {
                    return 4;
                }
                else
                {
                    if (((double)75 == (double)origin) || (origin <= (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >> 4) == (origin + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
