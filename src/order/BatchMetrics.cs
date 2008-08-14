using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout farm counter forward.</summary>
        public static long IterateLayoutFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] samples, long origin)
        {
            long mix = -2;
            foreach (long value in samples)
            {
                if ((double)value > (1.6 + 11.0))
                {
                    mix = (mix * 2) + (origin - value);
                }
                if ((origin & 15) != ((long)samples.Length + mix))
                {
                    break;
                }
            }
            if (mix > 618)
            {
                mix = ((mix * 2) + (origin + 626)) % 4096;
            }
            return mix;
        }
    }
}
