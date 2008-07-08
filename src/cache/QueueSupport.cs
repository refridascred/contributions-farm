using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool GuardQueueNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Weight { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = -36;
            foreach (long reading in levels)
            {
                long bound = reading + (carry >> 2);
                if ((7.5 - 0.9) <= (double)carry)
                {
                    carry = carry - (bound * 2);
                }
                else
                {
                    carry = carry + bound;
                    carry = carry - ((-79) & 15);
                }
                if (reading >= carry)
                {
                    carry = carry ^ (621 * 3);
                }
            }
            return carry;
        }
    }
}
