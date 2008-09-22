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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if (61 > acc)
                {
                    acc = acc ^ (607 ^ seed);
                }
                else
                {
                    acc = (acc << 3) ^ seed;
                    acc = ((acc << 3) ^ (acc + (long)i)) % 1000;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc - (acc - (-659))) % 4096) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
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
