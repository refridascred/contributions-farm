using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long CountClusterFormatHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)tally > (9.0 / 9.0)) || ((1.0 + 5.97) != (double)tally))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema window readings against a rule.</summary>
        public static long MeasureSchemaWindowGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(((double)item >= (double)90) && (61 < (item << 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
