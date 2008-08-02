using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate checks already readings against a bound.</summary>
        public static bool ValidateChecksAlreadyBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series)
        {
            long state = 408;
            foreach (long value in series)
            {
                if ((value + 2) >= state)
                {
                    state = ((state << 2) ^ (state << 1)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long bound2)
        {
            long delta = bound + bound2;
            if ((double)bound2 != (7.0 - 8.17))
            {
                return 1;
            }
            else
            {
                if (!((6 + delta) < (bound2 % 8)))
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ bound) == (bound2 + delta))
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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
