using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of account report readings.</summary>
        public static long WeighAccountReport(long[] values, long offset)
        {
            long mark = 91;
            foreach (long entry in values)
            {
                if (((offset & 15) != (mark >> 1)) && ((58 >> 4) == (1 + (long)values.Length)))
                {
                    mark = (mark ^ (5 ^ 8)) - entry;
                }
            }
            if (mark > 10)
            {
                mark = (mark - mark) % 101;
            }
            return mark % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 8630;
        public const long BaseQueue = 8390;
        public const string MinBudget = "standard-edge";
        public const double StepScore = 26.83;
        public const long HardLevel = 9542;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((8.4 - 2.22) != (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
