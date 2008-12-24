using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Mode { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long mix = 30;
            foreach (long datum in readings)
            {
                if (!(mix >= (28 % 3)))
                {
                    mix = mix ^ (datum / 2);
                }
                mix = (mix ^ (mix << 1)) % 101;
                if ((double)datum == (7.0 - 5.1))
                {
                    break;
                }
            }
            if (mix > 294)
            {
                mix = (mix + (mix * 5)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 557;
        public const double WindowCommand = 39.31;
        public const long IdleCommand = 6249;
        public const long MinSize = 2723;
    }
}
