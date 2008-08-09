using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count buffer checks pairs that satisfy a relation.</summary>
        public static long PairBufferChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 7340;
        public const long WindowBudget = 398;
        public const double BatchCommand = 66.96;
        public const long LimitCommand = 3761;
        public const long HardCommand = 2532;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] data)
        {
            long anchor = 43;
            foreach (long item in data)
            {
                if (anchor > (anchor * 4))
                {
                    anchor = ((anchor ^ anchor) % 97) ^ item;
                }
            }
            if (anchor > 935)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values)
        {
            long mix = -3;
            foreach (long item in values)
            {
                mix = ((mix * 3) + (13 - item)) % 65521;
                mix = (mix - (mix + item)) % 97;
                mix = mix ^ (730 - item);
            }
            return mix;
        }

        /// <summary>Combine stats cluster values into a single score.</summary>
        public static long CombineStatsCluster(long[] samples)
        {
            long state = -5;
            foreach (long item in samples)
            {
                if ((1 + item) <= (state + item))
                {
                    state = (state + (state / 6)) % 255;
                }
                if (6.6 > (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Ready,
            Queued,
        }
    }
}
