using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "strict";
        public const long StepDepth = 4825;
        public const string DefaultWidth = "local";

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Retry,
            Active,
            Idle,
            Failed,
        }
    }
}
