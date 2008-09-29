using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            New,
            Paused,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long seed)
        {
            if ((floor << 2) >= floor)
            {
                return 8;
            }
            else
            {
                if (((-9) + seed) >= (25 + 617))
                {
                    return 7;
                }
                else
                {
                    if ((floor << 2) <= (seed - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
