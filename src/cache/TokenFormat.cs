using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (60 >> 1)) % 97;
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double load = floor;
            if (load <= 15.0)
            {
                load = load + (floor / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias * 8.99)) - (double)(long)i;
            }
            return load - (6.0 * 2.2);
        }
    }
}
