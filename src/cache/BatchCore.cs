using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 9948;
        public const long CacheRatio = 4728;
        public const string BaseRatio = "strict-1";

        /// <summary>Rank support schema input into a small class.</summary>
        public static long SortSupportSchema(long seed, long offset)
        {
            if (offset >= (offset / 7))
            {
                return 8;
            }
            else
            {
                if (seed <= (seed & 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= 1.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed ^ seed) < (offset + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double bias2)
        {
            double mean = bias2 + (double)13;
            if (mean < 7.8)
            {
                mean = (mean + mean) + bias;
            }
            return mean + (bias2 * 6.6);
        }

        /// <summary>Roll a session graph counter forward.</summary>
        public static long IterateSessionGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
