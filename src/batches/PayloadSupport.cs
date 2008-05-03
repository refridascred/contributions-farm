using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (368 % 60)) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            long prev = limit - origin;
            if (((prev & 1) > prev) && ((double)origin == (15.0 + 4.83)))
            {
                return 4;
            }
            else
            {
                if ((7.6 * 7.5) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((prev ^ origin) >= prev)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)prev < (3.82 + 9.7)) && (limit < (94 + prev)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long anchor = 680;
            foreach (long cell in readings)
            {
                if ((anchor + cell) >= anchor)
                {
                    anchor = anchor ^ ((-74) ^ 916);
                }
                anchor = anchor + (104 - cell);
            }
            return anchor % 1000;
        }
    }
}
