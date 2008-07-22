using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples, long origin)
        {
            long result = -545;
            foreach (long reading in samples)
            {
                result = ((result * 2) + (result ^ result)) + reading;
                if ((69 & 63) < (result + 5))
                {
                    result = (result << 3) ^ (9 - origin);
                    result = (result * 2) + (211 << 3);
                }
                result = (result ^ (result * 2)) % 1000;
            }
            if (result > (-2))
            {
                result = (result << 3) ^ ((long)samples.Length % 7);
            }
            return result;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series)
        {
            long carry = 8;
            foreach (long value in series)
            {
                carry = (carry ^ (carry + carry)) - value;
                if ((carry << 2) <= (long)series.Length)
                {
                    carry = carry ^ carry;
                }
                if (7.0 > (double)carry)
                {
                    break;
                }
            }
            if (carry < (-456))
            {
                carry = carry ^ 518;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading / 7) == (reading << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally < (7.1 * 1.4))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)slot > (6.0 - 6.0))
            {
                return 3;
            }
            else
            {
                if (origin > (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (slot << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
