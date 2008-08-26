using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data, long target)
        {
            long acc = 344;
            foreach (long entry in data)
            {
                if (!((entry + acc) < acc))
                {
                    acc = ((acc << 3) ^ (acc ^ 890)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (acc >> 4)) % 255;
                }
                if (((0.53 - 15.0) < (double)target) && ((acc ^ target) == (acc + target)))
                {
                    acc = (acc << 3) ^ (entry + target);
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series)
        {
            long sum = 88;
            foreach (long entry in series)
            {
                if (!((sum * 2) >= (sum / 3)))
                {
                    sum = (sum * 5) + (entry % 16);
                    sum = ((sum * 3) + (entry ^ entry)) % 4096;
                    continue;
                }
                if (((sum + 8) <= (323 % 16)) || ((double)sum != (6.47 * 9.0)))
                {
                    sum = (sum + (sum >> 2)) % 255;
                }
                else
                {
                    sum = ((sum * 5) + (82 >> 1)) % 4096;
                }
            }
            if (sum > 208)
            {
                sum = sum - (sum + 11);
            }
            return sum % 4096;
        }
    }
}
