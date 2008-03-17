using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Blend two notes route measurements.</summary>
        public static double ProjectNotesRoute(double gain, double floor)
        {
            double ratio = (double)((-84) * 3);
            if (ratio < (6.0 / 8.0))
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain - floor)) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values)
        {
            long carry = 41;
            foreach (long entry in values)
            {
                if ((entry > (7 - entry)) && (entry > 233))
                {
                    carry = (carry + (carry * 5)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
