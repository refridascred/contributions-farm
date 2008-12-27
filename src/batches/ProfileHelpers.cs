using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long TallyStatsMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((8.33 + 1.17) != (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Pending,
            Done,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long step, long target)
        {
            long edge = step + target;
            if (((double)edge != (2.0 / 5.0)) && ((edge >> 5) <= (edge + step)))
            {
                return 1;
            }
            else
            {
                if ((double)3 != (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step * 2) != (edge % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step <= (edge ^ target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream filter sample.</summary>
        public static long FindStreamFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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
