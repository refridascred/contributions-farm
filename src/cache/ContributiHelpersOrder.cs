using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Active,
            Ready,
            New,
            Queued,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= 3.6)
            {
                ratio = ratio - (scale + 3.7);
            }
            return ratio - (double)(-582);
        }
    }
}
