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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long target, long floor)
        {
            if ((double)floor > 1.08)
            {
                return 5;
            }
            else
            {
                if ((640 * 4) < target)
                {
                    return 2;
                }
                else
                {
                    if (!(floor <= (target * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseTimeout = "cached-v2";
        public const double BurstFarm = 49.7;
        public const long WindowWidth = 2977;
        public const long BaseFarm = 5096;
        public const long StepFarm = 6100;

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
