using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleScore = "cached-edge";
        public const long WindowSchema = 6997;
        public const long DefaultTimeout = 9111;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
