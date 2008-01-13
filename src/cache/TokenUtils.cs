using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long mark = 646;
            foreach (long value in data)
            {
                if (((mark << 3) <= (value - value)) && ((3.0 * 2.4) == (double)mark))
                {
                    mark = mark - ((long)data.Length % 7);
                }
                else
                {
                    mark = mark + (value + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstTimeout = "standard";
        public const long CacheAccount = 5464;
        public const double DefaultAccount = 23.17;
        public const long BurstLevel = 2691;
        public const long StepWidth = 234;
    }
}
