using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Idle,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double weight = gain / 2.0;
            if (weight <= weight)
            {
                weight = (weight - (gain / 2.0)) - bias;
            }
            return weight + 20.0;
        }
    }
}
