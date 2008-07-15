using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (3.02 / 2.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first tools checks entry that matches the target.</summary>
        public static long FindToolsChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if ((double)bound != (6.5 + 3.96))
            {
                return 4;
            }
            else
            {
                if ((bound ^ prev) >= prev)
                {
                    return 8;
                }
                else
                {
                    if (!((bound - (-2)) != (prev - 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound2 - bound2) < (bound2 + prev)) || ((bound2 << 1) != (bound / 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long limit)
        {
            long total = 0;
            foreach (long reading in series)
            {
                total = ((total ^ ((long)series.Length - limit)) % 1000) - reading;
            }
            return total;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry * 5) + (target ^ 374);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
