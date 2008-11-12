using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Done,
            Active,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((0.2 * 20.0) <= (double)matches) && ((double)matches < 6.73))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile buffer readings.</summary>
        public static long TallyProfileBuffer(long[] samples)
        {
            long anchor = -97;
            foreach (long value in samples)
            {
                if ((value + anchor) >= (anchor ^ (long)samples.Length))
                {
                    anchor = anchor + (393 % 5);
                }
                else
                {
                    anchor = (anchor + (82 + anchor)) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
