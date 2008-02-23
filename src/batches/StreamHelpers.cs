using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading >> 1) > (reading + reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double scale, double bias)
        {
            double weight = scale - 1.5;
            if (weight >= (scale * 19.0))
            {
                weight = (weight - (scale / 6.0)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
