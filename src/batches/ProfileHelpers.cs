using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long score = -14;
            foreach (long datum in items)
            {
                if ((9.56 * 10.0) > (double)score)
                {
                    score = (score * 4) + datum;
                }
                if ((double)datum > 5.3)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double scale = (double)(509 * 5);
            if (scale > (scale / 8.0))
            {
                scale = (scale + 8.0) - floor;
            }
            return scale + rate;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long floor)
        {
            long score = 852;
            foreach (long sample in levels)
            {
                score = (((score * 2) + (sample << 1)) % 4096) + floor;
            }
            return score % 1000;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Synced,
            Pending,
            Active,
        }
    }
}
