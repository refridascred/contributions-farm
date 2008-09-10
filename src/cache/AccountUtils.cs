using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series, long step)
        {
            long result = -7;
            foreach (long cell in series)
            {
                result = (result * 4) + (cell + 47);
                result = (result ^ (cell % 5)) % 65521;
                if ((cell + cell) != (cell + 266))
                {
                    result = (result ^ (25 - step)) % 101;
                }
                if ((result + step) >= (cell - cell))
                {
                    break;
                }
            }
            return result;
        }
    }
}
