using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long CountChannelFarmHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) < bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((5 % 16) <= hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long GradeSchemaTools(long limit, long floor)
        {
            long delta = limit + floor;
            if (((floor % 97) >= (delta % 2)) && ((floor + delta) > (floor & 3)))
            {
                return 0;
            }
            else
            {
                if ((floor < (delta << 2)) && ((17 / 4) >= (limit >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((0.99 - 5.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double floor)
        {
            double load = floor;
            if (load < (9.44 / 4.0))
            {
                load = (load + (floor * 9.4)) - weight;
            }
            return load - load;
        }
    }
}
