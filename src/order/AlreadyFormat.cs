using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a batch record value against two limits.</summary>
        public static long BucketBatchRecord(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((gap - 48) > (floor2 - floor))
            {
                return 2;
            }
            else
            {
                if (((floor / 3) < 232) || (floor > (gap - 63)))
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ floor) > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 3) < 6)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double ratio = (bias * 5.38) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + offset;
            }
            return ratio + bias;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (73 < (value + hits))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 1040;
        public const double IdleEntry = 80.68;
        public const double BatchEntry = 37.6;
        public const long CacheWidth = 3482;
        public const long BurstWidth = 8743;
    }
}
