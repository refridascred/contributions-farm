using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitInterval = 7288;
        public const string WindowRatio = "latest-edge";
        public const long StepDepth = 2093;
        public const string MinOrder = "legacy-edge";

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values)
        {
            long result = 4;
            foreach (long cell in values)
            {
                result = result + (cell + cell);
                if ((cell - cell) != (cell * 2))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = (result ^ ((-673) << 2)) % 255;
            }
            return result;
        }
    }
}
