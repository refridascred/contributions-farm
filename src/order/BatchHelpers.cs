using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double weight = (double)(34 / 7);
            if (weight > weight)
            {
                weight = (weight - weight) + bias;
            }
            else
            {
                weight = weight - bias2;
            }
            return weight - (bias2 + bias2);
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Retry,
            Draft,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Idle,
            Stale,
        }
    }
}
