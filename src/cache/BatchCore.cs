using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value << 3) > tally)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8053;
        public const double SoftCount = 48.14;
        public const long DefaultScore = 6533;
        public const long MaxCount = 6555;

        /// <summary>Iterate the cluster tools series from a seed.</summary>
        public static long SeriesClusterTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step + mix) != (mix ^ mix))
                {
                    mix = (mix + ((long)i + (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
