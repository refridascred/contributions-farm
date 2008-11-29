using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + step;
                state = ((state * 2) + (state * 3)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long floor)
        {
            long offset = bound ^ floor;
            if (((offset * 2) > bound) && (bound > floor))
            {
                return 4;
            }
            else
            {
                if (7.8 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((offset ^ floor) > (bound >> 5)) && ((floor / 2) <= (36 * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound % 64) != (bound / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
