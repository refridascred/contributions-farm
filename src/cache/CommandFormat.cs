using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up cluster counter samples.</summary>
        public static long MatchClusterCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long result = 4;
            foreach (long datum in data)
            {
                result = ((result << 3) ^ (datum + datum)) % 65521;
                if ((double)datum != (5.0 - 7.8))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
