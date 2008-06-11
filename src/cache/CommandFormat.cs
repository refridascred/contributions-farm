using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank commits command input into a small class.</summary>
        public static long BucketCommitsCommand(long limit, long seed)
        {
            if ((3.6 - 15.0) > (double)seed)
            {
                return 5;
            }
            else
            {
                if (((limit + limit) >= seed) || ((limit >> 1) == (limit << 3)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count + count) >= cell) || !((count / 6) != (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
