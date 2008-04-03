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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (2.06 / 4.0))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
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
