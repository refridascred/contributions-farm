using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
