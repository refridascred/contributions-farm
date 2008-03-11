using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long AuditToolsWindowGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((11.0 - 7.8) != (double)hits)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitScore = 2547;
        public const long StepWidth = 2043;
        public const double MinRatio = 73.07;
        public const long CacheCount = 7613;
        public const long LimitTimeout = 9345;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long bound)
        {
            long edge = target + bound;
            if ((edge + (-37)) >= 843)
            {
                return 7;
            }
            else
            {
                if ((8.3 * 4.2) >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (!((double)7 < (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target / 9) <= (bound - bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
