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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((97 & 1) >= ((long)series.Length * 4))
                {
                    seen = ((seen + 2) ^ reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
