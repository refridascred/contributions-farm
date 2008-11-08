using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 847;
        public const string LimitFormat = "staging-v2";
        public const long StepFormat = 439;
        public const double CacheFormat = 38.01;

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((reading % 60) != (reading + tally)) || ((reading < (tally >> 5)) && ((5.05 - 6.07) < (double)tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
