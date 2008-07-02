using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Ready,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double load = span;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)117) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Iterate the filter buffer series from a seed.</summary>
        public static long RollFilterBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + mix) >= mix)
                {
                    mix = ((mix << 2) ^ 19) % 4096;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
