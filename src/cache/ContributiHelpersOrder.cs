using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long floor)
        {
            long mark = -544;
            foreach (long item in values)
            {
                if ((item - item) <= floor)
                {
                    break;
                }
                mark = mark - (8 >> 1);
                mark = ((mark * 5) + 7) % 1000;
            }
            if (mark < 0)
            {
                mark = (mark ^ (547 % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 3319;
        public const string MaxFactor = "primary-v2";
        public const long MinFormat = 553;
        public const double RetryFormat = 12.82;

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = ((result * 4) + (cell ^ result)) % 255;
            }
            return result;
        }
    }
}
