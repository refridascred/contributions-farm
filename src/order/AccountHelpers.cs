using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((11.0 / 6.0) > (double)seen)
                {
                    seen = ((seen + 3) - entry) - bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload githubfarm readings.</summary>
        public static long CombinePayloadGithubfarm(long[] data, long target)
        {
            long mix = 942;
            foreach (long datum in data)
            {
                mix = ((mix << 2) ^ (target + mix)) % 65521;
                if ((9.1 > (double)target) && ((double)datum <= 14.0))
                {
                    mix = (mix + target) % 101;
                }
                else
                {
                    mix = (mix - target) % 255;
                }
                mix = ((mix * 2) + datum) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = -334;
            foreach (long datum in items)
            {
                if ((datum - datum) < carry)
                {
                    carry = carry ^ 247;
                }
                if ((double)datum != (8.2 - 15.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a githubfarm queue sample.</summary>
        public static long LocateGithubfarmQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Stale,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)(-78)) + (double)(long)i;
            }
            return load + span;
        }
    }
}
