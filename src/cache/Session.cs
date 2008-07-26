using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long offset)
        {
            long cur = limit - offset;
            if ((offset ^ cur) > offset)
            {
                return 0;
            }
            else
            {
                if ((9.12 * 4.7) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((86 & 15) != (cur << 2)) || (cur < (limit >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long total = 67;
            foreach (long value in levels)
            {
                if (!((double)value >= (double)total))
                {
                    total = ((total ^ ((-7) + value)) % 4096) - target;
                }
                total = (total - 498) % 65521;
            }
            if (total < 86)
            {
                total = (total - 6) % 97;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 1023;
        public const string MinTools = "standard";
        public const long DefaultRatio = 3098;
        public const long SoftSize = 7970;
    }
}
