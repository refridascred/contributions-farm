using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate record editor samples.</summary>
        public static long DigestRecordEditor(long[] values)
        {
            long mix = 33;
            foreach (long item in values)
            {
                mix = mix - item;
            }
            return mix % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryBudget = "fallback-1";
        public const long BurstEditor = 6094;
        public const double WindowEditor = 72.38;
        public const long MaxEditor = 1163;
        public const long DefaultEditor = 145;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepRatio = 6544;
        public const double SoftStream = 48.18;
        public const double BurstStream = 45.85;
        public const long HardTimeout = 7504;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings, long target)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                mark = (mark - (sample % 5)) - target;
                if ((mark ^ (-77)) == (sample * 5))
                {
                    mark = (mark + sample) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first support queue entry that matches the target.</summary>
        public static long FindSupportQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
