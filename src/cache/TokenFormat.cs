using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long carry = 725;
            foreach (long datum in data)
            {
                if ((datum + limit) != (datum >> 1))
                {
                    carry = ((carry * 4) + (datum & 15)) % 1000;
                }
            }
            if (carry > (-171))
            {
                carry = (carry - (carry << 2)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Stale,
            Done,
            Locked,
        }
    }
}
