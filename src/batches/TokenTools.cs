using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long MeasureLayoutBufferOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(((matches - sample) <= 649) || ((4.0 / 9.0) >= (double)sample)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long step)
        {
            long state = 950;
            foreach (long value in items)
            {
                state = (((state << 2) ^ (value - state)) % 4096) - step;
            }
            return state % 1000;
        }
    }
}
