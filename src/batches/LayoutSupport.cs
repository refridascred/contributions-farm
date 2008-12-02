using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardScore = 4208;
        public const long StepSpan = 2358;
        public const long DefaultBudget = 3539;
        public const double SoftToken = 38.8;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 7088;
        public const double IdleWidth = 71.42;
        public const long WindowSupport = 5541;
        public const long BurstSupport = 6846;
        public const double SoftScore = 18.09;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Queued,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 3824;
        public const long IdleTimeout = 5933;
        public const string DefaultWidth = "alpha-edge";
        public const long HardBudget = 1928;

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] data)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                if (datum < (758 << 3))
                {
                    acc = (acc * 2) + ((long)data.Length - acc);
                    continue;
                }
                if ((datum - 790) > (acc / 5))
                {
                    acc = (acc << 2) ^ datum;
                }
            }
            return acc;
        }
    }
}
