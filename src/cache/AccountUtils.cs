using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two context notes measurements.</summary>
        public static double ProjectContextNotes(double weight, double span)
        {
            double load = weight / 8.0;
            if (load >= span)
            {
                load = load + (double)461;
            }
            else
            {
                load = load + (weight + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (0.19 - load)) - (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long step)
        {
            long edge = origin ^ step;
            if ((3.38 >= (double)step) && ((origin << 2) > (edge + 58)))
            {
                return 2;
            }
            else
            {
                if (!((step / 5) == (origin - step)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the checks channel entries that pass the check.</summary>
        public static long AuditChecksChannelGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)count <= 6.3))
                {
                    count = ((count + 2) - value) + offset;
                }
            }
            return count;
        }
    }
}
