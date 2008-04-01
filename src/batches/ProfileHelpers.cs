using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = state ^ (offset ^ (long)i);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9567;
        public const long BurstSchema = 6176;
        public const double HardInterval = 44.77;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long offset)
        {
            long score = 911;
            foreach (long cell in series)
            {
                if (offset > (offset >> 1))
                {
                    score = ((score * 5) + (offset - score)) + cell;
                }
            }
            if (score > 16)
            {
                score = (score << 3) ^ (offset / 2);
            }
            return score % 65521;
        }
    }
}
