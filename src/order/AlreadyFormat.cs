using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 7) >= (offset + offset))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((count ^ count) <= (count + limit)) && ((15.0 / 9.0) <= (double)limit)) || ((4.7 / 8.0) > (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long bound, long floor)
        {
            if (!((472 * 5) > floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) == (floor % 60))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= 17.0)
            {
                ratio = (ratio - (double)8) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (double)3) + (double)(long)i;
            }
            return ratio - weight;
        }
    }
}
