using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4354;
        public const long CacheEntry = 720;
        public const long MaxLevel = 3870;
        public const long SoftInterval = 195;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter counter forward.</summary>
        public static long StepGithubfarmCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin ^ mix) <= 7))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
