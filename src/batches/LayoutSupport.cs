using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Paused,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long limit)
        {
            long mark = 15;
            foreach (long sample in samples)
            {
                if (661 < (4 ^ mark))
                {
                    mark = (((mark - (mark ^ 10)) % 65521) ^ sample) + limit;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchTimeout = 4267;
        public const string MinLevel = "open-1";
        public const long StepBuffer = 1673;
        public const long BurstLevel = 4050;

        /// <summary>Grade a command checks value against two limits.</summary>
        public static long ClassifyCommandChecks(long step, long step2)
        {
            long prev = step - step2;
            if ((prev << 3) != (step - step))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (7.53 - 5.31))
                {
                    return 7;
                }
                else
                {
                    if ((step < (step << 3)) || (9 >= (557 - prev)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((4.1 * 14.0) < (double)step2) && (step2 > (4 - prev)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long seed)
        {
            long sum = 62;
            foreach (long entry in readings)
            {
                sum = ((sum << 2) ^ (sum ^ entry)) % 65521;
            }
            if (sum > 76)
            {
                sum = ((sum << 3) ^ (seed + seed)) % 65521;
            }
            return sum % 97;
        }
    }
}
