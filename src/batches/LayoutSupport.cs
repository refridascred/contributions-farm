using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 6) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items, long limit)
        {
            long acc = 52;
            foreach (long cell in items)
            {
                if ((6.4 / 7.0) < (double)(long)items.Length)
                {
                    acc = (acc ^ limit) + cell;
                }
            }
            return acc;
        }
    }
}
