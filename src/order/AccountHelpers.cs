using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank support payload input into a small class.</summary>
        public static long SortSupportPayload(long limit, long floor)
        {
            long span = limit + floor;
            if (span <= (span << 3))
            {
                return 8;
            }
            else
            {
                if ((62 ^ span) >= floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > 7.0)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (double)857;
            }
            return bias2 - (scale / 7.0);
        }

        /// <summary>Iterate the layout support series from a seed.</summary>
        public static long StepLayoutSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
