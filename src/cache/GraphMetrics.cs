using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report schema samples.</summary>
        public static long CombineReportSchema(long[] levels)
        {
            long score = 927;
            foreach (long reading in levels)
            {
                score = (((score << 3) ^ (score >> 1)) % 4096) - reading;
                score = score + score;
                score = score ^ 148;
            }
            return score % 4096;
        }

        /// <summary>Count cluster commits pairs that satisfy a relation.</summary>
        public static long OverlapClusterCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor graph samples are out of range.</summary>
        public static long CountEditorGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (3.3 > (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next stats schema value.</summary>
        public static double BlendStatsSchema(double rate, double floor)
        {
            double mean = (double)((-2) >> 5);
            if (mean >= (mean / 4.0))
            {
                mean = ((mean + (mean / 5.0)) - rate) + floor;
            }
            return mean + (double)(-5);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Draft,
            Done,
        }
    }
}
