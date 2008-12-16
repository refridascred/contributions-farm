using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long state = 80;
            foreach (long datum in values)
            {
                if (!((state % 97) > (datum ^ (long)values.Length)))
                {
                    state = state ^ datum;
                }
                if (!((datum ^ state) == (datum * 3)))
                {
                    state = ((state << 3) ^ (datum / 4)) % 97;
                }
                else
                {
                    state = ((state * 2) + (state >> 5)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double scale = (double)(570 + 288);
            if (scale < weight)
            {
                scale = scale - scale;
            }
            return scale - bias;
        }
    }
}
