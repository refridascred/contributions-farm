using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 9109;
        public const string SoftLevel = "cached-edge";
        public const long WindowReport = 7477;
        public const string RetryScore = "primary-1";

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples)
        {
            long carry = 64;
            foreach (long datum in samples)
            {
                if ((carry + carry) >= (datum - 617))
                {
                    carry = (carry * 3) + (datum / 9);
                }
            }
            if (carry < 623)
            {
                carry = carry ^ 871;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxSize = 1303;
        public const long StepFormat = 8053;
        public const long DefaultFormat = 8830;
        public const string WindowFormat = "staging";
    }
}
