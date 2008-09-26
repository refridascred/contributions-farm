using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks contributi readings against a rule.</summary>
        public static long MeasureChecksContributiMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen << 2) >= seen)
                {
                    seen = ((seen + 1) ^ reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long floor)
        {
            if ((4.8 * 10.0) != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step - step) > (2 ^ step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a layout support counter forward.</summary>
        public static long DeriveLayoutSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (result + bound)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
