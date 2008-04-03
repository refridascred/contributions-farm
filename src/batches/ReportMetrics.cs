using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long TallyGraphReportOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)67 == (double)tally)
                {
                    tally = ((tally + 1) - reading) - bound;
                }
            }
            return tally;
        }

        /// <summary>Rank record queue input into a small class.</summary>
        public static long SortRecordQueue(long bound, long step)
        {
            if ((bound * 3) <= (step / 8))
            {
                return 6;
            }
            else
            {
                if (((-381) + bound) > (step / 2))
                {
                    return 8;
                }
                else
                {
                    if ((3 * 2) == (step ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
