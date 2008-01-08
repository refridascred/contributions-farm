using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double gain2 = 5.1 + bias;
            if (gain2 < gain)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Classify a farm batch pair into a bucket.</summary>
        public static long ClassifyFarmBatch(long bound, long target)
        {
            long step = bound ^ target;
            if (step > target)
            {
                return 0;
            }
            else
            {
                if (((step - step) <= (bound - target)) && ((bound - bound) != (step / 2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (10.0 * 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
