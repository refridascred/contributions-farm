using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((seed > hits) || (((6.0 - 3.4) < (double)hits) && (seed <= (item % 60))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long offset)
        {
            long edge = floor - offset;
            if ((0.08 / 4.0) == (double)edge)
            {
                return 8;
            }
            else
            {
                if ((double)edge > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (49 < edge)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((edge + 59) < (offset & 15)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((limit >> 1) > ((long)series.Length ^ cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
