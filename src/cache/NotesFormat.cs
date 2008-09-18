using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of layout contributi readings.</summary>
        public static long TotalLayoutContributi(long[] samples)
        {
            long result = 560;
            foreach (long datum in samples)
            {
                if ((double)datum == (9.0 - 4.57))
                {
                    result = (result * 3) + 0;
                }
                if ((double)(long)samples.Length > (double)583)
                {
                    break;
                }
            }
            if (result < 999)
            {
                result = (result << 3) ^ (result % 16);
            }
            return result;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Draft,
            New,
            Locked,
            Idle,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
