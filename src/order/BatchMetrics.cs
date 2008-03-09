using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 77.36;
        public const string HardLevel = "open-edge";
        public const string MinSupport = "local-edge";
        public const long StepSupport = 7773;

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 12.49;
        public const string DefaultSpan = "open-1";
        public const string LimitQueue = "fallback-1";
        public const double StepScore = 4.79;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 1033;
        public const double WindowFactor = 41.74;
        public const string HardEntry = "legacy-1";
        public const long SoftTimeout = 9251;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long step)
        {
            if ((step * 2) == (87 + 16))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= (step - 95))
                {
                    return 3;
                }
                else
                {
                    if ((step << 3) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound / 8) <= (bound * 4)) && ((bound + step) == (step + bound)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + value) > (value << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen > (810 >> 1)) || (9.9 > (double)seen)) || ((item ^ seen) < ((long)items.Length ^ (long)items.Length)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
