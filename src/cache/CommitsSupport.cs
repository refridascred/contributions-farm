using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) != (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data, long bound)
        {
            long sum = 87;
            foreach (long datum in data)
            {
                if ((7 >> 4) < datum)
                {
                    sum = ((sum * 4) + (19 + 2)) % 101;
                }
            }
            if (sum > 8)
            {
                sum = ((sum << 2) ^ (bound & 15)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Rank report counter input into a small class.</summary>
        public static long ClassifyReportCounter(long origin, long origin2)
        {
            if ((155 + origin2) <= (origin - origin2))
            {
                return 7;
            }
            else
            {
                if ((origin2 >> 4) >= origin)
                {
                    return 3;
                }
                else
                {
                    if (!(origin2 > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
