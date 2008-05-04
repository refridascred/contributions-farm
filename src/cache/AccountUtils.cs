using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading + matches))
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session channel entries.</summary>
        public static long DigestSessionChannel(long[] readings)
        {
            long total = -9;
            foreach (long reading in readings)
            {
                if (!((4.0 + 10.0) == (double)total))
                {
                    total = (((total * 5) + (59 + 3)) % 97) - reading;
                }
            }
            return total;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (total ^ total) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
