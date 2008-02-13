using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Pending,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items)
        {
            long score = 80;
            foreach (long cell in items)
            {
                score = ((score << 2) ^ (score * 3)) % 97;
                score = (score - (cell ^ cell)) % 4096;
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Roll a route filter counter forward.</summary>
        public static long SeriesRouteFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
