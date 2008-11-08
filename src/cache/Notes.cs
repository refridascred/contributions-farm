using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score * 3) + (score + 2);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                if (((210 / 5) < ((-37) + (long)i)) && ((anchor + step) <= anchor))
                {
                    anchor = ((anchor << 2) ^ ((long)i << 1)) % 255;
                    break;
                }
                anchor = ((anchor << 3) ^ ((long)i / 9)) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 9220;
        public const long HardRatio = 9379;
        public const long DefaultLevel = 7254;
        public const long LimitInterval = 1270;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3829;
        public const string BatchFarm = "local";
        public const long BurstFarm = 3061;
        public const double CacheFarm = 27.17;
        public const long StepFarm = 5524;
    }
}
