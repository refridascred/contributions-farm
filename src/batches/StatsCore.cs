using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long target)
        {
            long bound = offset + target;
            if ((offset * 4) >= target)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (1.8 * 4.6)) || ((target - offset) < 25))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 * 17.0) >= 3.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next profile channel value from a seed.</summary>
        public static long RollProfileChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (-64)) % 255;
                mark = (mark ^ (bound << 2)) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings)
        {
            long carry = -47;
            foreach (long cell in readings)
            {
                if ((carry + carry) == (carry - cell))
                {
                    carry = (carry + (carry - cell)) % 101;
                }
                if ((carry - cell) <= (cell << 3))
                {
                    carry = (carry * 3) + cell;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!!((double)sample > (5.0 - 0.3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
