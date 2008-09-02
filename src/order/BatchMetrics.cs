using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Closed,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3021;
        public const long SoftSize = 660;
        public const long IdleLevel = 4970;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3477;
        public const string IdlePayload = "latest-edge";
        public const string BurstScore = "primary-v2";

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series)
        {
            long carry = 2;
            foreach (long value in series)
            {
                if (((carry >> 2) != (carry % 3)) || ((carry + value) != (value >> 1)))
                {
                    carry = (carry * 4) + (-478);
                }
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1175;
        public const long WindowCount = 9176;
        public const double HardLevel = 16.23;
    }
}
