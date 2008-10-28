using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Done,
            Stale,
        }

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long TallyContributiReportMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen % 5) < (datum << 2)) || ((datum - bound) < (datum - 666))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
