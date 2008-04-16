using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum >= (seen / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double load = 4.0;
            if (load <= (double)2)
            {
                load = load - (double)732;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (rate - load)) + (double)(long)i;
            }
            return load + (load + span);
        }
    }
}
