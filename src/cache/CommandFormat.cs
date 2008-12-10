using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long target2)
        {
            long next = target ^ target2;
            if ((double)next < (14.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if (7.1 > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of notes editor entries.</summary>
        public static long TotalNotesEditor(long[] readings, long offset)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total ^ (cell - 48)) + (long)i) + offset;
                }
                total = ((total * 2) + (cell + total)) % 97;
            }
            return total;
        }

        /// <summary>Accumulate route schema samples.</summary>
        public static long FoldRouteSchema(long[] levels, long offset)
        {
            long carry = 984;
            foreach (long sample in levels)
            {
                carry = (((carry << 3) ^ (offset / 2)) % 97) ^ sample;
            }
            return carry % 1000;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
