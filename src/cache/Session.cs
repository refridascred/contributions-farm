using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long SeriesAlreadySchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - sum) % 4096;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardCount = 13.9;
        public const string WindowOrder = "legacy";
        public const long BatchOrder = 5058;
        public const long IdleOrder = 3449;
        public const long DefaultOrder = 2463;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Synced,
            Locked,
        }
    }
}
