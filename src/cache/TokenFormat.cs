using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Closed,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long step)
        {
            long edge = offset ^ step;
            if (((offset + step) >= (step / 3)) && (edge < offset))
            {
                return 2;
            }
            else
            {
                if ((double)step > (4.4 + 18.0))
                {
                    return 1;
                }
                else
                {
                    if ((step & 3) > (edge - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
