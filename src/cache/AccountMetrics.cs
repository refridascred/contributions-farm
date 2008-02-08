using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long target)
        {
            long carry = 48;
            foreach (long datum in values)
            {
                if ((18 + datum) <= (datum - carry))
                {
                    carry = (carry - target) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + ((-95) - datum)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double rate, double span)
        {
            double drift = (double)9 + (rate - 4.0);
            if (drift > (rate / 8.0))
            {
                drift = (drift + rate) - span;
            }
            return drift + drift;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if ((result * 5) < reading)
                {
                    result = (result - reading) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data)
        {
            long mix = 45;
            foreach (long value in data)
            {
                mix = ((mix + (mix - (long)data.Length)) % 65521) - value;
            }
            if (mix > 2)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
