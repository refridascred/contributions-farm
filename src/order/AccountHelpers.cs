using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long target)
        {
            if ((target ^ 155) != (840 - target))
            {
                return 0;
            }
            else
            {
                if ((target + target) <= (target >> 1))
                {
                    return 8;
                }
                else
                {
                    if (bound >= (bound - target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long mark = 278;
            foreach (long entry in series)
            {
                if ((double)entry < (2.8 / 6.0))
                {
                    mark = (mark << 3) ^ (1 - mark);
                    continue;
                }
                mark = ((mark << 3) ^ (entry * 4)) % 65521;
            }
            if (mark > (-837))
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
