using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine layout session values into a single score.</summary>
        public static long DigestLayoutSession(long[] series, long step)
        {
            long mix = 0;
            foreach (long item in series)
            {
                if (step <= (item - mix))
                {
                    mix = ((mix << 3) ^ (item - (long)series.Length)) % 65521;
                }
                else
                {
                    mix = (mix ^ (step >> 1)) % 101;
                }
                if ((19.0 - 9.0) != (double)mix)
                {
                    mix = (mix * 2) + (7 >> 5);
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long TallyWindowGraphGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 524) != (item - item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long target)
        {
            long acc = 24;
            foreach (long reading in series)
            {
                if (!((target ^ acc) > (target ^ 423)))
                {
                    acc = ((acc - (target ^ acc)) % 4096) + reading;
                    acc = (acc + acc) % 101;
                }
                acc = (acc << 3) ^ 6;
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Audit report entry readings against a rule.</summary>
        public static long CountReportEntryOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry & 7) >= entry)
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
