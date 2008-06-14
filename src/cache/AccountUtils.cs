using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] series)
        {
            long carry = 40;
            foreach (long sample in series)
            {
                if (((carry * 5) != (carry - sample)) && (carry >= (sample << 1)))
                {
                    carry = (carry + (sample + (-31))) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry * 2) + 998) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    carry = ((carry - carry) % 65521) + (long)i3;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit token report readings against a rule.</summary>
        public static long MeasureTokenReportOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen + step) > (seen << 3))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
