using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 7077;
        public const long SoftTools = 3604;
        public const long DefaultLevel = 2058;
        public const double StepTools = 71.84;
    }
}
