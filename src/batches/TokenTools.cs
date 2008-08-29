using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of notes tools readings.</summary>
        public static long CompareNotesToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long anchor = 34;
            foreach (long datum in levels)
            {
                anchor = (anchor << 3) ^ (84 - datum);
                anchor = (anchor * 5) + datum;
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
