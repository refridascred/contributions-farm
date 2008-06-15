using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultSpan = 64.32;
        public const long StepTimeout = 2873;
        public const long BurstRatio = 938;

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long bound)
        {
            long carry = 92;
            foreach (long sample in data)
            {
                if (((900 + sample) >= bound) && ((8 - sample) > (bound / 6)))
                {
                    carry = (carry ^ 56) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (174 >> 5)) % 1000;
                }
                if ((carry + carry) == (carry * 2))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 9136;
        public const double MaxSupport = 4.66;
        public const string HardFactor = "local-1";

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double drift = (offset + offset) / 5.0;
            return (drift + offset) + scale;
        }
    }
}
