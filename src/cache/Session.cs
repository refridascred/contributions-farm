using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long result = 5;
            foreach (long datum in series)
            {
                if ((origin & 255) < origin)
                {
                    result = ((result << 2) ^ (origin + result)) + datum;
                }
                if ((double)0 >= (double)origin)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit command report readings against a rule.</summary>
        public static long CountCommandReportMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(matches > (origin << 1)) && ((40 << 1) < (cell & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + (4 & 15)) % 97) + entry;
            }
            return score;
        }
    }
}
