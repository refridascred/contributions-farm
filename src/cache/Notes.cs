using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long seed)
        {
            long cur = target ^ seed;
            if (!((seed + target) == (4 + target)))
            {
                return 0;
            }
            else
            {
                if ((seed - cur) <= target)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed != (7.8 - 17.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((target << 1) > (target % 12)))
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
        }

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long TallyEntrySupportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (72 >> 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token cluster entries.</summary>
        public static long WeighTokenCluster(long[] samples, long bound)
        {
            long sum = 7;
            foreach (long entry in samples)
            {
                if (((double)sum >= 4.7) || (((-573) + 56) < (sum % 5)))
                {
                    sum = ((sum << 3) ^ (bound - bound)) % 97;
                }
                if ((19 - bound) <= (bound + sum))
                {
                    sum = ((sum << 3) ^ (sum + 834)) % 255;
                    sum = ((sum * 5) + (sum ^ sum)) % 255;
                }
                if ((-63) <= (bound + bound))
                {
                    sum = (sum + (entry >> 1)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every profile format entry stays within the limit.</summary>
        public static bool GuardProfileFormatLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
