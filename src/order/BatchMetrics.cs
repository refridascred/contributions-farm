using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor2 - lane) >= ((-244) << 1))
            {
                return 3;
            }
            else
            {
                if (((floor ^ 741) != (floor ^ floor2)) || ((8.82 - 9.4) < (double)floor2))
                {
                    return 2;
                }
                else
                {
                    if ((lane + floor2) != (lane - lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((floor + 778) <= (datum - 9)) || (((tally - floor) >= floor) && ((floor >> 2) >= 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 1415;
        public const double MinRatio = 95.39;
        public const long SoftWidth = 3456;
        public const string BatchCount = "strict";

        /// <summary>Match up metric editor samples.</summary>
        public static long CompareMetricEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
