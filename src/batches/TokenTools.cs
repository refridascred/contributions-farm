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

        /// <summary>Measure how many context queue samples are out of range.</summary>
        public static long TallyContextQueueMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally > (7.0 + 9.29))
                {
                    tally = ((tally + 1) + reading) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
