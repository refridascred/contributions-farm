using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - item) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next stream graph value.</summary>
        public static double AdjustStreamGraph(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (offset - ratio))
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            return ratio + (double)83;
        }
    }
}
