using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > 7)
                {
                    hits = ((hits + 2) - datum) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long seed, long target)
        {
            long offset = seed ^ target;
            if ((seed % 12) <= (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((target & 15) <= seed)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i << 1) != ((long)i ^ sum))
                {
                    sum = sum - ((long)i << 3);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long offset)
        {
            long carry = 83;
            foreach (long sample in items)
            {
                if (((5.0 / 8.0) != (double)carry) || ((double)sample != (1.9 * 3.31)))
                {
                    carry = ((carry * 3) + (carry + offset)) % 1000;
                }
                else
                {
                    carry = (carry + (carry & 255)) % 97;
                }
            }
            if (carry < 49)
            {
                carry = (carry ^ (carry + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
