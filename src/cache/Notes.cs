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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long seed, long origin)
        {
            if (seed <= (812 * 5))
            {
                return 0;
            }
            else
            {
                if ((origin / 8) != (seed - origin))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
