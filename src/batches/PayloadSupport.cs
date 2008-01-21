using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((6.2 - 15.0) < (double)reading)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Grade a token batch value against two limits.</summary>
        public static long BucketTokenBatch(long offset, long step)
        {
            long step2 = offset + step;
            if ((5.63 / 4.0) == (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)1 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((offset + step2) < step2) && ((double)offset != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
