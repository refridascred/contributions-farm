using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double gain = (double)((-75) >> 5);
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + gain) + (double)(long)i) - scale) + offset;
            }
            return gain + (2.0 / 8.0);
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long step2)
        {
            long slot = step ^ step2;
            if ((-189) >= (slot << 2))
            {
                return 0;
            }
            else
            {
                if ((double)slot <= (4.96 * 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((0.9 + 1.02) == (double)step2)
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

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Queued,
            Synced,
        }
    }
}
