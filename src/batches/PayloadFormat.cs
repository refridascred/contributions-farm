using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (double)matches)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support stream readings.</summary>
        public static long ScoreSupportStream(long[] items)
        {
            long sum = 90;
            foreach (long cell in items)
            {
                if ((cell >> 4) >= cell)
                {
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum - 237)) % 101;
                }
                if ((sum * 5) <= (sum + cell))
                {
                    sum = (sum - sum) % 4096;
                }
                if ((6.16 - 5.59) > (double)cell)
                {
                    sum = (sum - sum) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((-43) & 1) == (matches % 24))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
