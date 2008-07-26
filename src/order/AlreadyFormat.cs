using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double bias, double bias2)
        {
            double weight = bias2;
            return (weight + (bias2 / 4.0)) + bias;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (reading > result)
                {
                    result = (result - (result ^ 9)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Count the cluster farm entries that pass the check.</summary>
        public static long CountClusterFarmGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample >= (8 & 255))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
