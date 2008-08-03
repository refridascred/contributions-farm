using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheFactor = 8296;
        public const double BatchInterval = 82.07;
        public const string BatchCluster = "cached";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 85.29;
        public const long IdleCount = 6538;
        public const long BaseBatches = 7629;

        /// <summary>Validate farm buffer readings against a bound.</summary>
        public static bool CheckFarmBufferLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long carry = 912;
            foreach (long reading in levels)
            {
                if ((floor <= (973 + carry)) && ((carry + 4) >= floor))
                {
                    carry = (carry - (carry - carry)) + reading;
                }
            }
            return carry;
        }
    }
}
