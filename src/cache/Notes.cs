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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long origin2)
        {
            if (origin > (899 / 6))
            {
                return 3;
            }
            else
            {
                if (6 < (origin2 - origin))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
