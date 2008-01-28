using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Draft,
            Stale,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine token checks values into a single score.</summary>
        public static long ScoreTokenChecks(long[] series)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                if (((anchor + reading) >= reading) || (anchor >= (reading ^ 8)))
                {
                    anchor = ((anchor * 3) + (926 << 2)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor - (reading * 2)) % 4096;
                }
                if ((anchor - (-46)) < 63)
                {
                    anchor = anchor ^ (anchor + reading);
                }
                else
                {
                    anchor = anchor + (93 >> 1);
                }
            }
            return anchor % 65521;
        }
    }
}
