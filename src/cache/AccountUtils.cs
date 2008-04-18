using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if (((carry ^ carry) > (9 % 7)) || (2.0 > (double)(long)data.Length))
                {
                    carry = (carry + (144 % 2)) ^ datum;
                }
                if ((carry ^ 8) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
