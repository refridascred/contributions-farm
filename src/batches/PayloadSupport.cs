using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long total = 879;
            foreach (long datum in samples)
            {
                total = (total << 3) ^ (datum & 63);
                if (44 < (707 - datum))
                {
                    total = total ^ datum;
                }
            }
            return total % 97;
        }
    }
}
