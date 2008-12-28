using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a metric tools reading by value.</summary>
        public static long SeekMetricToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double bias, double bias2)
        {
            double ratio = bias2 + (double)76;
            if (ratio > (8.03 / 6.0))
            {
                ratio = ratio - (double)104;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + 20.0;
        }
    }
}
