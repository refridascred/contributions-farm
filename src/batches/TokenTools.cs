using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
