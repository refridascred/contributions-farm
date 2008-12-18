using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long total = 18;
            foreach (long item in data)
            {
                if (!((item >> 4) < (item << 2)))
                {
                    total = ((total * 5) + (item << 3)) % 255;
                }
                if ((8.1 * 17.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 5) + (target << 2);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleDepth = 64.65;
        public const long CacheCounter = 4497;
        public const long BaseRatio = 6387;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            New,
            Pending,
        }
    }
}
