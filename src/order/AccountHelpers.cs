using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long bound)
        {
            long next = offset + bound;
            if ((double)next < (0.9 - 17.0))
            {
                return 7;
            }
            else
            {
                if ((next * 3) <= (bound & 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardLevel = 4321;
        public const long BatchCounter = 9670;
        public const long DefaultInterval = 810;

        /// <summary>Find the first farm schema entry that matches the target.</summary>
        public static long FindFarmSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading & 63) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the session editor entries that pass the check.</summary>
        public static long AuditSessionEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value - 478) <= (value * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double bias)
        {
            double drift = bias - (bias - scale);
            return drift + (double)288;
        }
    }
}
