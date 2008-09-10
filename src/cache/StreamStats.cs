using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseLevel = 2374;
        public const long StepCache = 801;
        public const long DefaultSpan = 2320;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5885;
        public const long MaxLevel = 2061;
        public const long HardLevel = 2748;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long origin)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                if ((double)acc < 9.38)
                {
                    acc = ((acc + (acc / 4)) % 255) ^ reading;
                }
                else
                {
                    acc = (acc + (origin - 4)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}
