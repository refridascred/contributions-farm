using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 68.94;
        public const string CacheBatches = "primary-edge";
        public const string StepBatches = "alpha-edge";
        public const long WindowBatches = 4383;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool ValidateCounterCacheBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] levels, long limit)
        {
            long result = 95;
            foreach (long sample in levels)
            {
                result = (result - 479) % 97;
                if (limit > (sample ^ limit))
                {
                    result = result - (157 - sample);
                }
            }
            return result;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= (double)1)
            {
                gain2 = (gain2 - gain2) + gain;
            }
            return gain2 - gain2;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
