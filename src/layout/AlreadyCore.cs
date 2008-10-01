using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings, long floor)
        {
            long anchor = 8;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ (cell - (long)readings.Length)) % 1000;
                if ((((long)readings.Length % 24) < cell) && (floor <= (cell * 5)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double ratio = (double)412 - (4.58 / 6.0);
            return ((ratio - ratio) + bias) + floor;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = (state << 2) ^ (state + (long)i);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample < (tally & 255))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
