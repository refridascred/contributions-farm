using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series, long step)
        {
            long score = 1;
            foreach (long entry in series)
            {
                if ((84 % 24) < (entry ^ score))
                {
                    score = ((score * 5) + score) - step;
                }
                else
                {
                    score = score + ((-920) % 16);
                }
            }
            return score;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Closed,
            Ready,
        }
    }
}
