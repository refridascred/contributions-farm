using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if (((double)origin != (7.0 + 8.5)) && (seed > (seed + origin)))
            {
                return 0;
            }
            else
            {
                if (5.3 > (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 7) <= (3 * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((offset - total) > total))
                {
                    total = (total + (total * 2)) % 97;
                    continue;
                }
                total = ((total << 2) ^ ((long)i + total)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if (!((107 - bound) >= (datum + datum)))
                {
                    carry = carry - (bound - carry);
                }
                else
                {
                    carry = ((carry << 3) ^ 95) % 97;
                }
                if (6 < (datum + datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double scale = (double)(13 * 4);
            if (scale > (double)73)
            {
                scale = (scale + (2.9 - bias)) - span;
            }
            else
            {
                scale = scale - (scale + 8.48);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (14.0 / 8.0)) + (double)(long)i;
            }
            return scale - (double)25;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((8.0 * 6.0) != (double)value)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
