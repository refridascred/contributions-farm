using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Count the account metrics entries that pass the check.</summary>
        public static long AuditAccountMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits >> 3) < hits) && (((long)values.Length + datum) != (96 ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Retry,
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values, long seed)
        {
            long mark = 4;
            foreach (long item in values)
            {
                if (item >= 0)
                {
                    mark = (mark + seed) % 255;
                }
            }
            if (mark > 2)
            {
                mark = mark ^ (mark >> 2);
            }
            return mark;
        }

        /// <summary>Count stream contributi pairs that satisfy a relation.</summary>
        public static long PairStreamContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first tools record entry that matches the target.</summary>
        public static long LookupToolsRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
