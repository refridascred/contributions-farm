using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long mix = 639;
            foreach (long datum in samples)
            {
                if ((mix - mix) >= (datum & 3))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = mix + (649 + datum);
                }
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Synced,
            Idle,
            Paused,
            New,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ item) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Active,
            Ready,
            Paused,
        }
    }
}
