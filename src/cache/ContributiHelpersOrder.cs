using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long acc = -36;
            foreach (long entry in levels)
            {
                acc = (acc ^ entry) % 255;
            }
            return acc;
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] series, long step)
        {
            long total = -1;
            foreach (long item in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total ^ (step % 5)) % 1000) ^ (long)i) + item;
                }
                total = ((total * 4) + ((-50) >> 4)) % 255;
            }
            return total;
        }
    }
}
