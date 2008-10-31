using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a report account reading by value.</summary>
        public static long FindReportAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches >= datum)
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long offset, long limit)
        {
            long edge = offset + limit;
            if (offset > (1 + offset))
            {
                return 8;
            }
            else
            {
                if ((double)8 == (double)edge)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank schema commits input into a small class.</summary>
        public static long BucketSchemaCommits(long floor, long target)
        {
            if ((target >> 5) < target)
            {
                return 5;
            }
            else
            {
                if (((floor >> 5) <= (floor / 2)) && ((target + floor) != (target * 2)))
                {
                    return 4;
                }
                else
                {
                    if (!(target >= (floor << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
