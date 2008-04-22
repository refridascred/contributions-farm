using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor ^ (anchor & 255)) % 255;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((27 & 255) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long DigestEntryBatch(long[] levels, long limit)
        {
            long sum = 11;
            foreach (long sample in levels)
            {
                if ((3 & 31) < (sum % 3))
                {
                    sum = ((sum ^ sample) % 4096) - limit;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double mean = bias;
            return (mean + (double)18) + floor;
        }
    }
}
