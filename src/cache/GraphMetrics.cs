using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cluster editor entry stays within the limit.</summary>
        public static bool VerifyClusterEditorBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 680;
            foreach (long cell in readings)
            {
                mix = (mix - (mix + mix)) + cell;
            }
            if (mix < 0)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long DeriveMetricsQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 3) ^ (target % 100)) % 4096;
                result = (result + (747 * 5)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long sum = 31;
            foreach (long reading in items)
            {
                if ((sum <= (7 << 1)) || ((double)reading < (0.2 - 6.0)))
                {
                    sum = (sum + (reading << 2)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (sum - sum)) % 1000;
                }
            }
            return sum;
        }
    }
}
