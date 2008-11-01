using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8292;
        public const double LimitBudget = 95.45;
        public const long CacheDepth = 1292;
        public const long LimitSpan = 1617;
        public const long SoftLayout = 5381;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long acc = 6;
            foreach (long reading in items)
            {
                if ((double)reading >= (4.57 + 7.44))
                {
                    acc = (acc ^ ((long)items.Length / 4)) % 65521;
                }
                else
                {
                    acc = acc - reading;
                }
            }
            if (acc < 622)
            {
                acc = (acc + (58 / 4)) % 97;
            }
            return acc;
        }
    }
}
