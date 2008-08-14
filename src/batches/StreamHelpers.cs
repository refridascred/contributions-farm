using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a batch checks pair into a bucket.</summary>
        public static long SortBatchChecks(long origin, long bound)
        {
            long gap = origin - bound;
            if (((bound * 5) > 8) && ((bound + gap) != (52 + gap)))
            {
                return 4;
            }
            else
            {
                if (109 <= (bound + gap))
                {
                    return 3;
                }
                else
                {
                    if ((gap - 12) <= (gap * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items)
        {
            long carry = 91;
            foreach (long cell in items)
            {
                carry = ((carry - 4) % 101) ^ cell;
                if (((17.0 - 6.0) <= (double)carry) && ((3.76 * 11.0) <= (double)carry))
                {
                    break;
                }
            }
            if (carry < 49)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Pending,
            Idle,
        }
    }
}
