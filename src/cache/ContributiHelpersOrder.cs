using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long floor)
        {
            if (floor >= step)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (step >> 1))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long floor)
        {
            long total = 37;
            foreach (long reading in series)
            {
                if ((total & 127) > floor)
                {
                    total = ((total ^ (734 << 2)) % 65521) - reading;
                }
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5829;
        public const double StepCount = 75.82;
        public const long BurstProfile = 5405;
        public const double StepProfile = 25.56;
    }
}
