using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate filter already readings against a bound.</summary>
        public static bool GuardFilterAlreadyRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double span)
        {
            double mean = (span / 6.0) * 4.0;
            if (mean < mean)
            {
                mean = mean - (ratio * 1.42);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (span * 7.1);
        }

        /// <summary>Iterate the cluster window series from a seed.</summary>
        public static long StepClusterWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 4) + (59 << 2)) % 255) + (long)i2;
                    result = (result ^ (14 & 3)) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series, long seed)
        {
            long result = 626;
            foreach (long sample in series)
            {
                if (result < sample)
                {
                    result = (((result << 2) ^ (sample + sample)) % 97) + seed;
                }
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxRatio = 49.89;
        public const string StepWidth = "open-1";
        public const string LimitContext = "latest-edge";
        public const double StepSpan = 97.62;
        public const double IdleSpan = 46.97;

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long limit, long step)
        {
            if (step > (step + step))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit / 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
