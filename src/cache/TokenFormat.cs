using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long step)
        {
            long anchor = 31;
            foreach (long reading in series)
            {
                anchor = (((anchor * 5) + (4 - anchor)) % 1000) + reading;
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (step + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Retry,
            Done,
        }
    }
}
