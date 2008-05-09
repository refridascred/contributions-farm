using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command stream counter forward.</summary>
        public static long SeriesCommandStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ ((long)i % 64)) % 65521;
                mix = ((mix << 3) ^ (46 + limit)) % 101;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 65;
        public const long SoftGithubfarm = 5437;
        public const double BurstBudget = 89.12;
        public const long BurstGithubfarm = 2284;
        public const string MinLevel = "open-v2";

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
