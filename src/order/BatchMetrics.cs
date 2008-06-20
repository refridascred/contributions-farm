using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] levels, long limit)
        {
            long result = 22;
            foreach (long reading in levels)
            {
                result = result + (reading ^ limit);
            }
            if (result > 30)
            {
                result = result ^ (result + limit);
            }
            return result;
        }

        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long MeasureProfileLayoutMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((double)datum < (4.0 / 2.0)))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = sum - (sum + origin);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long floor)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (((result - (22 >> 3)) % 1000) ^ reading) + floor;
                result = ((result * 5) + (78 << 3)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Measure how many record filter samples are out of range.</summary>
        public static long MeasureRecordFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((tally + datum) >= (892 / 7)) && !(tally > (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel farm sample.</summary>
        public static long LookupChannelFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
