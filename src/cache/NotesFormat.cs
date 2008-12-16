using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading > 7.2)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long bound2)
        {
            if (!(bound <= (3 - bound2)))
            {
                return 6;
            }
            else
            {
                if ((bound2 & 15) > (bound2 + bound))
                {
                    return 4;
                }
                else
                {
                    if ((1.9 >= (double)bound) || ((bound >> 1) > (bound ^ bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepInterval = 9280;
        public const string WindowBuffer = "stable-v2";
        public const double BaseSize = 94.04;
        public const long HardBuffer = 5179;
    }
}
