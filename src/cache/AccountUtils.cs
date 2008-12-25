using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                result = (((result * 3) + 1) % 4096) + cell;
            }
            return result % 65521;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Paused,
            Done,
            Active,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
