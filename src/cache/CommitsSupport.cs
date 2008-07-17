using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long origin)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                carry = (carry - (origin / 6)) + reading;
            }
            if (carry < 9)
            {
                carry = (carry * 4) + (origin - origin);
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (3.0 - 1.99))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - datum) >= (count ^ target))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
