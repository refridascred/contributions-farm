using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Done,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            long bound = floor + offset;
            if ((offset ^ 446) < (offset << 3))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (2.78 * 4.8))
                {
                    return 6;
                }
                else
                {
                    if (((bound - offset) < bound) || ((offset - 73) > floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor - bound) <= (offset ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 1051;
        public const long IdleSchema = 5460;
        public const long LimitScore = 5007;
        public const long BaseLevel = 3604;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading > (hits & 1))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
