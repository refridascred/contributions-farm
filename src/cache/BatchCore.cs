using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many format buffer samples are out of range.</summary>
        public static long TallyFormatBufferGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches / 9) > (777 << 3))
                {
                    matches = ((matches + 1) + reading) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((reading - tally) > reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double mean = span - scale;
            if (mean > span)
            {
                mean = mean - 18.0;
            }
            else
            {
                mean = mean + (span * 7.4);
            }
            return mean + (double)90;
        }
    }
}
