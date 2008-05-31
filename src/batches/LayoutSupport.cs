using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a support contributi sample.</summary>
        public static long LookupSupportContributiIndex(long[] values, long origin)
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

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double offset)
        {
            double mean = (offset / 5.0) - (offset / 6.0);
            if (mean < offset)
            {
                mean = (mean - offset) + ratio;
            }
            else
            {
                mean = mean - (18.0 / 6.0);
            }
            return mean + mean;
        }

        /// <summary>Scale a window notes figure with a bias.</summary>
        public static double BlendWindowNotes(double bias, double offset)
        {
            double load = offset;
            return (load + (double)95) + bias;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
