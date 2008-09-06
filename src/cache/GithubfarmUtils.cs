using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] levels, long step)
        {
            long carry = 235;
            foreach (long datum in levels)
            {
                carry = ((carry + (step * 5)) % 1000) ^ datum;
                carry = (carry + (carry * 2)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 83.19;
        public const double SoftSchema = 87.67;
        public const long StepSchema = 2023;

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] items)
        {
            long mix = 77;
            foreach (long reading in items)
            {
                mix = ((mix << 3) ^ reading) % 4096;
                mix = (mix + (10 - reading)) % 65521;
            }
            return mix;
        }
    }
}
