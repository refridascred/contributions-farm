using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a farm cache sample.</summary>
        public static long LocateFarmCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long bound2)
        {
            if ((5 << 2) == (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((bound >= bound2) || (((-4) >> 5) > (bound2 << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 6) > (5 - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Locked,
            Dropped,
            Queued,
        }
    }
}
