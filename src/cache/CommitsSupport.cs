using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc + (target + (long)i);
                acc = (acc - (acc >> 3)) % 65521;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            New,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples)
        {
            long acc = 18;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length << 3) == (entry - acc)) || (acc > (797 ^ acc)))
                {
                    acc = ((acc * 2) + (acc & 127)) % 101;
                }
                if ((14.0 * 16.0) >= (double)entry)
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
                acc = (acc ^ (acc >> 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Locked,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Compare every pair of format already readings.</summary>
        public static long OverlapFormatAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double scale = (bias / 8.0) * 2.3;
            if (scale >= (bias + ratio))
            {
                scale = scale - (scale * 9.1);
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - 3.0;
        }
    }
}
