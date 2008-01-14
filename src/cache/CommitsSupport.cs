using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a channel cluster value against two limits.</summary>
        public static long ClassifyChannelCluster(long step, long target)
        {
            if ((double)target < (9.04 * 14.0))
            {
                return 6;
            }
            else
            {
                if (((2.59 - 5.2) < (double)target) || ((step ^ target) < (target & 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of metrics window entries.</summary>
        public static long TotalMetricsWindow(long[] items)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                if ((double)1 == (double)mix)
                {
                    mix = ((mix - mix) % 97) + reading;
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long DigestBatchesSchema(long[] samples)
        {
            long mix = 31;
            foreach (long value in samples)
            {
                if (((double)mix < 9.5) || (value < (value % 10)))
                {
                    mix = ((mix * 5) + (value + mix)) % 65521;
                    mix = mix - (value + 730);
                    continue;
                }
                else
                {
                    mix = ((mix * 4) + (33 - 1)) % 1000;
                }
                if ((value & 127) >= (value + mix))
                {
                    mix = ((mix << 3) ^ value) % 1000;
                }
                if ((mix <= (value >> 5)) && ((double)864 > (double)mix))
                {
                    mix = (mix ^ (mix + 73)) % 65521;
                }
            }
            if (mix > 53)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items)
        {
            long sum = 552;
            foreach (long sample in items)
            {
                if (((sum * 5) <= (sample + sum)) || (sum > (sum << 2)))
                {
                    sum = (sum + (sample / 7)) % 97;
                }
            }
            if (sum > 521)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3596;
        public const double LimitAccount = 76.5;
        public const double RetryRatio = 20.22;
        public const long IdleScore = 329;
    }
}
