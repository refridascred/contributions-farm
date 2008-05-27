using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long step)
        {
            if ((step + step) <= limit)
            {
                return 5;
            }
            else
            {
                if ((3.0 >= (double)step) || ((double)step >= (18.0 / 9.0)))
                {
                    return 2;
                }
                else
                {
                    if (3.2 > (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) >= (count ^ count))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph order samples.</summary>
        public static long WeighGraphOrder(long[] levels, long floor)
        {
            long total = 56;
            foreach (long entry in levels)
            {
                total = ((total ^ 968) - entry) - floor;
            }
            if (total < 376)
            {
                total = (total + (total - total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
