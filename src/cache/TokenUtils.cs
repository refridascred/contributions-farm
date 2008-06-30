using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double offset)
        {
            double drift = (scale - offset) * 0.2;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (offset - scale)) - (double)(long)i;
            }
            return drift - (offset - scale);
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitTimeout = 7757;
        public const long BatchTimeout = 5028;
        public const long HardProfile = 4649;
    }
}
