using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit command already readings against a rule.</summary>
        public static long CountCommandAlreadyGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((3.9 * 2.4) <= (double)value))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double ratio, double offset)
        {
            double rate = (double)((-43) - 1);
            if (rate < offset)
            {
                rate = (rate + offset) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - 6.0;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long state = 41;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = state ^ 6;
                    state = (state + (long)i) % 4096;
                }
                if (!((double)cell <= (double)state))
                {
                    state = (state + cell) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Done,
            Active,
            Ready,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((2.5 + 11.0) < (double)tally)
                {
                    tally = ((tally + 1) + item) - floor;
                }
            }
            return tally;
        }
    }
}
