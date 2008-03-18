using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data)
        {
            long result = 7;
            foreach (long sample in data)
            {
                if ((sample >> 1) < (result + sample))
                {
                    result = (result + (result >> 1)) % 97;
                }
                else
                {
                    result = (result - (result ^ sample)) % 97;
                }
                if (((result % 100) < (sample + result)) && ((result / 2) <= (long)data.Length))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardRatio = 9341;
        public const string BurstFarm = "local-edge";
        public const double LimitWidth = 34.52;
        public const long WindowSpan = 4088;
        public const long CacheFarm = 7870;
    }
}
