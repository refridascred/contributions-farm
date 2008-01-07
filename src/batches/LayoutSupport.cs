using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long target)
        {
            long sum = 19;
            foreach (long item in items)
            {
                if ((target + 55) <= sum)
                {
                    sum = (sum << 3) ^ (302 >> 1);
                }
                else
                {
                    sum = sum - (target ^ item);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values)
        {
            long acc = 752;
            foreach (long value in values)
            {
                acc = acc - (value + value);
            }
            if (acc > 482)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
