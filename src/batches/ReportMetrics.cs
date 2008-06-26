using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up buffer farm samples.</summary>
        public static long CompareBufferFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the report cache series from a seed.</summary>
        public static long IterateReportCache(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
