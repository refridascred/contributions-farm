using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long origin)
        {
            long state = 1;
            foreach (long value in readings)
            {
                if (((origin * 5) < (origin * 4)) && ((origin - state) != (value - 9)))
                {
                    state = (state * 5) + ((-1) - state);
                }
            }
            if (state > 711)
            {
                state = ((state << 3) ^ (state + origin)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate cluster batch samples.</summary>
        public static long WeighClusterBatch(long[] series)
        {
            long anchor = 96;
            foreach (long sample in series)
            {
                if ((sample ^ anchor) <= anchor)
                {
                    anchor = ((anchor * 2) + (sample ^ sample)) % 65521;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a already contributi counter forward.</summary>
        public static long DeriveAlreadyContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = state + (state - target);
                state = ((state * 2) + target) % 4096;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double scale, double bias)
        {
            double mean = (double)((-46) - 2);
            return (mean + scale) + bias;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
