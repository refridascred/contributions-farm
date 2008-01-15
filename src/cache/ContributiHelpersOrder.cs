using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data)
        {
            long anchor = 300;
            foreach (long value in data)
            {
                if ((double)anchor <= (16.0 + 2.0))
                {
                    anchor = (anchor ^ 31) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ (value + value);
                }
                if ((5 & 15) != (anchor << 3))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Synced,
            Idle,
        }
    }
}
