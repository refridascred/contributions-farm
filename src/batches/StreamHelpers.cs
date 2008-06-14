using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 3.24;
        public const long WindowBudget = 8503;
        public const long LimitQueue = 2495;
        public const long HardFactor = 566;
        public const long StepScore = 862;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double scale2 = scale - scale;
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (span - scale)) + (double)(long)i;
            }
            return scale2 - (span / 3.0);
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

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
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
