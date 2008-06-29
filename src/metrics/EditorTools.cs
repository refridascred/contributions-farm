using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double load = bias;
            if (load < (load * 3.0))
            {
                load = load - (load - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 14.0) + (double)(long)i;
            }
            return load - (double)843;
        }
    }
}
