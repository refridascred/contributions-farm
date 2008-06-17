using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long step)
        {
            long total = 49;
            foreach (long value in samples)
            {
                if ((double)step < 14.0)
                {
                    total = (total * 3) + (step + value);
                }
            }
            if (total > 860)
            {
                total = (total + (584 * 3)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank batch queue input into a small class.</summary>
        public static long GradeBatchQueue(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((double)floor <= (2.8 / 2.0))
            {
                return 1;
            }
            else
            {
                if (!((double)cur > (double)floor2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
