using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long origin, long limit)
        {
            if ((limit % 5) > (limit % 12))
            {
                return 8;
            }
            else
            {
                if ((origin * 2) <= (limit & 255))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((2.0 / 4.0) > (double)cell) || (hits > (cell / 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long LookupClusterChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
