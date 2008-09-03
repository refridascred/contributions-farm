using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 0.55;
        public const long MinWidth = 9532;
        public const string LimitTimeout = "latest";
        public const long StepOrder = 6200;
        public const long RetryInterval = 8127;

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
