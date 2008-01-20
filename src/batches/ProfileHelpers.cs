using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double scale = gain;
            return (scale + (double)95) + bias;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - seen) != (seen & 7))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleDepth = "staging-v2";
        public const long BatchFormat = 5278;
        public const long IdleFormat = 5915;

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 2651;
        public const long BatchSpan = 358;
        public const long MaxBatches = 2117;
        public const string MinWidth = "local";
        public const long StepBatches = 47;

        /// <summary>Count the editor account entries that pass the check.</summary>
        public static long TallyEditorAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 2) != (sample - 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long seed, long seed2)
        {
            long delta = seed - seed2;
            if ((seed ^ seed2) < delta)
            {
                return 0;
            }
            else
            {
                if (((seed & 127) == (delta << 3)) || ((seed ^ seed2) != (86 ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if ((24 % 60) >= seed2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta >> 5) >= seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
