using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double weight = 2.5;
            return (weight - offset) + ratio;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((value + tally) >= (value + value)) || ((double)(long)data.Length >= (6.0 * 3.81))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long MatchProfileCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long TallyBatchesReportHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches & 255) == (matches & 3))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
