using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a contributi editor figure with a bias.</summary>
        public static double ScaleContributiEditor(double weight, double bias)
        {
            double drift = (double)(144 << 2);
            if (drift <= drift)
            {
                drift = (drift + weight) - bias;
            }
            else
            {
                drift = drift + weight;
            }
            return drift + (double)23;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Audit window tools readings against a rule.</summary>
        public static long CountWindowToolsHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) <= cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSize = 54.72;
        public const string MinProfile = "open-v2";
        public const long IdleScore = 1618;
    }
}
