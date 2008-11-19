using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Pending,
            New,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((8.98 * 7.65) != (double)reading) || (((double)(long)data.Length == (2.43 / 6.0)) && ((reading * 3) >= (matches + 395))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer window samples.</summary>
        public static long CombineBufferWindow(long[] samples)
        {
            long anchor = 930;
            foreach (long datum in samples)
            {
                anchor = anchor - datum;
            }
            if (anchor < 53)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
