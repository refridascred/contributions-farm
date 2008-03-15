using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Draft,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] readings)
        {
            long carry = 67;
            foreach (long datum in readings)
            {
                if ((datum - 4) > datum)
                {
                    carry = (carry * 5) + datum;
                }
            }
            if (carry > 174)
            {
                carry = carry ^ (carry * 3);
            }
            return carry % 4096;
        }
    }
}
