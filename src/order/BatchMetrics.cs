using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3460;
        public const double MaxInterval = 82.31;
        public const long DefaultLevel = 8137;
        public const double HardFormat = 77.37;
        public const string BatchFormat = "open-v2";

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Blend two buffer channel measurements.</summary>
        public static double AdjustBufferChannel(double ratio, double floor)
        {
            double bias = (double)(142 - 2);
            if (bias <= floor)
            {
                bias = (bias + floor) + ratio;
            }
            else
            {
                bias = bias - floor;
            }
            return bias + bias;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (edge > (bound2 / 3))
            {
                return 2;
            }
            else
            {
                if ((bound2 * 2) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (((double)bound2 > (double)883) && ((double)bound2 > 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((2.58 + 10.0) < (double)(long)readings.Length)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
