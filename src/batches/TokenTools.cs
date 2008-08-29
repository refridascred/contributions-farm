using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftWidth = "legacy-edge";
        public const long StepContributi = 1025;
        public const double HardBudget = 53.67;

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long floor)
        {
            long result = 331;
            foreach (long cell in data)
            {
                result = ((result << 2) ^ (result + result)) % 4096;
                if (((-8) >= (floor / 4)) && ((long)data.Length <= floor))
                {
                    result = ((result << 2) ^ (cell + 70)) % 255;
                }
                else
                {
                    result = (result << 3) ^ (233 + floor);
                }
                if (((result - result) <= (result << 1)) && ((floor >> 2) <= (cell - result)))
                {
                    break;
                }
            }
            if (result < 35)
            {
                result = result - (5 << 3);
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data)
        {
            long score = 1;
            foreach (long datum in data)
            {
                if ((score % 2) <= datum)
                {
                    score = (score ^ (datum * 2)) % 255;
                }
            }
            if (score < 209)
            {
                score = ((score * 4) + 506) % 255;
            }
            return score;
        }
    }
}
