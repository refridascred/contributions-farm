using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step / 6) <= (step - (-898)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9395;
        public const long CacheFarm = 4770;
        public const long StepFarm = 8956;
        public const double BaseFarm = 14.2;
        public const long StepRatio = 4349;

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long total = -602;
            foreach (long datum in data)
            {
                if ((datum << 2) >= (91 + total))
                {
                    break;
                }
                total = (total ^ datum) % 101;
            }
            return total % 4096;
        }
    }
}
