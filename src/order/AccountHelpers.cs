using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long limit)
        {
            if ((618 >> 5) > target)
            {
                return 5;
            }
            else
            {
                if ((double)limit != (7.73 + 19.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (5.62 * 1.4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)target > (double)949) || (0 <= (target % 97)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value + hits) >= (40 + value)) || ((hits <= (value * 4)) && ((17.0 + 4.54) <= (double)hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (2.58 * 0.4))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
