using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a route support pair into a bucket.</summary>
        public static long SortRouteSupport(long limit, long origin)
        {
            if ((double)limit > (6.7 - 3.8))
            {
                return 8;
            }
            else
            {
                if (3.48 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                if ((entry - entry) == (225 - 885))
                {
                    sum = ((sum * 2) + (sum / 7)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
            }
            if (sum > 13)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
