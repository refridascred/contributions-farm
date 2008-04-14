using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long AuditGraphTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits ^ 84) > (datum << 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score - (81 / 7);
                if ((29 + (-6)) != (target / 2))
                {
                    score = (score - target) % 255;
                }
                score = score + target;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
