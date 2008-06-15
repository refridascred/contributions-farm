using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 3.24;
        public const long WindowBudget = 8503;
        public const long LimitQueue = 2495;
        public const long HardFactor = 566;
        public const long StepScore = 862;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            if ((double)step <= (8.02 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((8.8 * 4.29) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed - 597) != (seed ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if ((floor + floor) >= (floor * 4))
            {
                return 7;
            }
            else
            {
                if ((floor << 2) >= step)
                {
                    return 0;
                }
                else
                {
                    if (293 < (floor ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ step) > (step ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (((mark * 3) + (floor * 3)) % 4096) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value < (seen & 127))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
