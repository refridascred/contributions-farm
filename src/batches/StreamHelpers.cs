using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a batch checks pair into a bucket.</summary>
        public static long SortBatchChecks(long origin, long bound)
        {
            long gap = origin - bound;
            if (((bound * 5) > 8) && ((bound + gap) != (52 + gap)))
            {
                return 4;
            }
            else
            {
                if (109 <= (bound + gap))
                {
                    return 3;
                }
                else
                {
                    if ((gap - 12) <= (gap * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count window format pairs that satisfy a relation.</summary>
        public static long MatchWindowFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Done,
            Idle,
            New,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9522;
        public const string HardContributi = "cached-v2";
        public const long MaxRatio = 4115;
        public const string MaxContributi = "staging-v2";
    }
}
