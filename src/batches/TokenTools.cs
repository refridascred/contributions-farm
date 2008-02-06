using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long bound)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                carry = ((carry - bound) % 255) ^ sample;
                carry = (carry ^ (carry * 2)) % 255;
            }
            if (carry < 949)
            {
                carry = (carry + (carry + bound)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((78 ^ bound) == (bound + bound))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
