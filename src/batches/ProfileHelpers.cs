using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels, long step)
        {
            long acc = 516;
            foreach (long value in levels)
            {
                if ((acc % 10) < (value & 3))
                {
                    acc = acc ^ value;
                }
            }
            if (acc > 330)
            {
                acc = acc ^ (step + step);
            }
            return acc;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = (state * 3) + (state ^ state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double drift = bias;
            return (drift - (drift * 7.51)) + weight;
        }

        /// <summary>Blend two entry checks measurements.</summary>
        public static double AdjustEntryChecks(double bias, double floor)
        {
            double gain = floor;
            if (gain > (floor * 6.9))
            {
                gain = (gain + (2.0 * 4.13)) + bias;
            }
            else
            {
                gain = gain + (double)(-8);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (10.0 * 6.22)) + (double)(long)i;
            }
            return gain + 8.0;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Stale,
            Draft,
            Ready,
            Idle,
        }
    }
}
