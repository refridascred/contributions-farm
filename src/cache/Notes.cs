using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool VerifyProfileRouteBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the session editor series from a seed.</summary>
        public static long DeriveSessionEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((step * 3) <= (step ^ step)))
                {
                    acc = (acc * 2) + (-680);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a report support pair into a bucket.</summary>
        public static long GradeReportSupport(long bound, long floor)
        {
            if (!((floor + floor) >= floor))
            {
                return 0;
            }
            else
            {
                if (((floor >> 5) > floor) || ((8.0 - 14.0) < (7.09 - 11.0)))
                {
                    return 3;
                }
                else
                {
                    if (3.1 > (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 1946;
        public const long MaxLevel = 9677;
        public const long LimitStream = 9631;

        /// <summary>Validate stream profile readings against a bound.</summary>
        public static bool CheckStreamProfileBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
