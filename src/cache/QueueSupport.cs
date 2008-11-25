using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + hits) >= (hits * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = total - (4 + 83);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + (long)samples.Length) == (item - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
