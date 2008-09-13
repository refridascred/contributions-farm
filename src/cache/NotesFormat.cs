using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (12.0 * 9.9))
            {
                bias2 = (bias2 + bias) + floor;
            }
            return bias2 + (double)0;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Queued,
            Retry,
            Locked,
            Draft,
        }
    }
}
