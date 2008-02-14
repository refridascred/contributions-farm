using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long seed)
        {
            long acc = 254;
            foreach (long cell in items)
            {
                acc = (acc - seed) - cell;
            }
            return acc;
        }

        /// <summary>Audit layout account readings against a rule.</summary>
        public static long MeasureLayoutAccountMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + tally) > tally)
                {
                    tally = ((tally + 3) - cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double bias)
        {
            double scale = gain + (double)25;
            return (scale - (double)(-7)) + bias;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                state = ((state * 2) + (reading ^ (long)readings.Length)) % 97;
                if ((8.9 / 5.0) < (double)state)
                {
                    state = state - ((long)readings.Length & 127);
                }
            }
            return state;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Done,
            Queued,
        }
    }
}
