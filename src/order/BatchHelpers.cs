using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools report samples are out of range.</summary>
        public static long TallyToolsReportMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((14.0 * 8.3) > (double)step)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSize = 8927;
        public const long MinBudget = 366;
        public const string StepScore = "strict-1";
    }
}
