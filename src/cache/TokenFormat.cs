using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a farm token reading.</summary>
        public static double ProjectFarmToken(double weight, double offset)
        {
            double load = offset / 3.0;
            if (load >= load)
            {
                load = load + weight;
            }
            return load - (offset * 3.55);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Retry,
            Pending,
        }
    }
}
