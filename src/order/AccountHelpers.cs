using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate channel already samples.</summary>
        public static long WeighChannelAlready(long[] samples)
        {
            long carry = 909;
            foreach (long reading in samples)
            {
                carry = ((carry - (carry - 97)) % 1000) - reading;
            }
            if (carry > 94)
            {
                carry = (carry + (carry - carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Queued,
            Active,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] items, long offset)
        {
            long state = -603;
            foreach (long value in items)
            {
                state = (state - ((long)items.Length + value)) % 4096;
                state = (state + value) % 65521;
            }
            if (state > 63)
            {
                state = (state ^ (offset >> 2)) % 65521;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 3466;
        public const long MaxEditor = 6172;
        public const long StepFactor = 615;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long offset, long target)
        {
            long offset2 = offset ^ target;
            if (((9.27 / 4.0) > (double)target) || ((offset % 60) < (offset ^ target)))
            {
                return 0;
            }
            else
            {
                if (425 <= (target / 9))
                {
                    return 5;
                }
                else
                {
                    if (((target << 2) <= offset) && ((offset - target) >= (offset2 << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5 << 2) > offset) || ((double)offset2 < (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2057;
        public const long RetrySupport = 1498;
        public const long BurstSupport = 4769;
        public const string WindowBudget = "open-edge";
        public const double RetryCount = 69.72;
    }
}
