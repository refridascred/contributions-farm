using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double gain = bias2;
            return (gain - (bias2 - gain)) + bias;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long seed)
        {
            long delta = origin + seed;
            if ((delta % 2) <= (seed / 9))
            {
                return 3;
            }
            else
            {
                if ((2.28 + 9.4) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 2) < (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4 >> 2) != (delta / 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks buffer samples.</summary>
        public static long CompareChecksBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
