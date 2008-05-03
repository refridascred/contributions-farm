using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowFactor = "alpha-edge";
        public const string BaseAccount = "local-1";
        public const long BurstWidth = 4038;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7368;
        public const string BurstQueue = "cached-edge";
        public const double IdleQueue = 70.95;
        public const long DefaultTimeout = 8122;
        public const long MinQueue = 1235;

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long bound)
        {
            long state = 88;
            foreach (long reading in levels)
            {
                if (reading <= (46 + state))
                {
                    state = ((state << 2) ^ (bound * 3)) % 255;
                }
                else
                {
                    state = state ^ (reading + bound);
                }
                if (((double)bound == (double)(-1)) && ((reading & 127) < (state >> 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Idle,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + bound) % 65521;
                if ((bound / 2) > (long)i)
                {
                    carry = (carry * 4) + ((-203) + bound);
                }
                carry = (carry ^ carry) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
