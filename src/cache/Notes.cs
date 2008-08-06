using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "primary-edge";
        public const long SoftGraph = 5682;
        public const long MaxLevel = 1911;
        public const double IdleInterval = 91.82;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 7131;
        public const double IdleScore = 3.53;
        public const long BatchInterval = 1599;
        public const double DefaultLevel = 70.75;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry + count) <= (26 % 8))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long score = 31;
            foreach (long sample in readings)
            {
                if ((double)score <= (5.63 / 5.0))
                {
                    score = (((score ^ (score >> 3)) % 65521) + sample) - origin;
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
