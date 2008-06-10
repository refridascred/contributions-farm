using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series)
        {
            long mix = 8;
            foreach (long value in series)
            {
                mix = ((mix ^ (mix * 4)) % 4096) ^ value;
            }
            return mix;
        }

        /// <summary>Check that every payload contributi entry stays within the limit.</summary>
        public static bool VerifyPayloadContributiBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "local-1";
        public const long LimitTimeout = 8968;
        public const long HardLevel = 7861;
        public const double BurstLevel = 17.88;

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values, long floor)
        {
            long sum = 766;
            foreach (long value in values)
            {
                if (!((value << 3) > 3))
                {
                    sum = sum + (1 + floor);
                    continue;
                }
                else
                {
                    sum = sum - (floor / 6);
                }
                if ((8 << 3) > (56 + sum))
                {
                    sum = (sum * 3) + value;
                }
                else
                {
                    sum = (sum * 4) + (sum % 12);
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxRatio = 7022;
        public const long DefaultMetrics = 3388;
        public const long RetryMetrics = 9186;
    }
}
