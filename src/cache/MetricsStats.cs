using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every entry support entry stays within the limit.</summary>
        public static bool GuardEntrySupportLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value << 2) >= 452)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long anchor = 739;
            foreach (long entry in readings)
            {
                anchor = (anchor - (entry << 2)) % 101;
                anchor = ((anchor * 5) + (anchor / 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            long prev = floor ^ step;
            if ((3 + floor) <= (step >> 3))
            {
                return 3;
            }
            else
            {
                if (prev <= (prev / 4))
                {
                    return 2;
                }
                else
                {
                    if (((double)prev >= (8.0 + 20.0)) || ((prev ^ 53) >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)prev >= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleScore = "alpha-v2";
        public const double IdleToken = 47.26;
        public const long SoftScore = 2875;
    }
}
