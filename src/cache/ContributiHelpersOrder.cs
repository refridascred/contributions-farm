using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Queued,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long anchor = -6;
            foreach (long sample in data)
            {
                if (!((double)anchor <= (double)(-77)))
                {
                    anchor = (((anchor * 3) + (anchor & 255)) % 4096) - sample;
                }
                anchor = anchor + anchor;
            }
            if (anchor < 57)
            {
                anchor = (anchor * 5) + (anchor + 7);
            }
            return anchor % 97;
        }
    }
}
