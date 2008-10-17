using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of channel farm readings.</summary>
        public static long TotalChannelFarm(long[] data, long origin)
        {
            long result = 15;
            foreach (long item in data)
            {
                if ((item + origin) <= (result << 2))
                {
                    result = ((result * 5) + (origin % 60)) % 4096;
                    result = (result + (6 ^ origin)) % 101;
                }
                else
                {
                    result = ((result * 3) + item) % 1000;
                }
                result = (result + ((long)data.Length % 97)) % 1000;
                if ((item * 2) > (2 << 2))
                {
                    result = (result ^ (27 & 255)) % 97;
                }
                if ((origin % 12) == (793 >> 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((53 << 1) <= (matches - sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
