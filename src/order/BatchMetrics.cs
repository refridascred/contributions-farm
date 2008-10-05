using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            New,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long WeighPayloadBatches(long[] data)
        {
            long total = -1;
            foreach (long cell in data)
            {
                total = total + (cell * 3);
                total = (total - ((-906) + cell)) % 65521;
                if (2.23 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long IdleQueue = 7111;
        public const long WindowQueue = 8974;
        public const double MinQueue = 15.82;

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 21.77;
        public const long WindowCount = 3356;
        public const long BatchSize = 5787;
        public const string CacheRatio = "stable";
        public const double BaseBudget = 62.18;

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "alpha-1";
        public const long SoftProfile = 1718;
        public const long RetryProfile = 7741;
        public const long DefaultProfile = 9056;
    }
}
