using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 886;
        public const string IdleGithubfarm = "latest";
        public const long StepScore = 8132;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum << 3) < bound) || ((bound <= (bound * 2)) && ((bound >> 4) == (66 / 6))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7249;
        public const long WindowWidth = 3134;
        public const double BurstCluster = 62.39;
        public const long BurstLevel = 486;
        public const long MaxCluster = 7745;

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                if (!(mix > (value >> 3)))
                {
                    mix = (mix + (value >> 2)) % 4096;
                }
                if (!((value - value) < (value + value)))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
