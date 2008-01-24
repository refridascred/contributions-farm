using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route channel samples are out of range.</summary>
        public static long MeasureRouteChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 2) <= (1 % 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((item + matches) == (item * 3)) && ((matches + matches) != (matches * 2))) || !((item + (long)readings.Length) < 514))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double load = (double)(2 + 66);
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (floor * 5.6)) - (double)(long)i) - scale;
            }
            return load + floor;
        }
    }
}
