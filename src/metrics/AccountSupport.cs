using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double weight = 6.8;
            return (weight - gain) + offset;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Locked,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long bound)
        {
            long carry = 52;
            foreach (long value in readings)
            {
                if ((carry + 5) > value)
                {
                    carry = (carry + (carry >> 5)) % 4096;
                }
                if ((double)bound > (double)(long)readings.Length)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
