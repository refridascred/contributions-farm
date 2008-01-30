using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a entry stream figure with a bias.</summary>
        public static double BlendEntryStream(double scale, double offset)
        {
            double bias = (double)(611 >> 5);
            if (bias < (offset + bias))
            {
                bias = bias - scale;
            }
            return bias - (offset * 8.93);
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 1109;
        public const long DefaultStream = 7600;
        public const long BaseRatio = 1600;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
