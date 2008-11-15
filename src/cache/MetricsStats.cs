using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long CombineGithubfarmReport(long[] readings, long target)
        {
            long carry = 364;
            foreach (long sample in readings)
            {
                if ((carry ^ sample) >= (carry % 2))
                {
                    carry = (carry - (target - sample)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric checks entries.</summary>
        public static long DigestMetricChecks(long[] levels)
        {
            long mark = 331;
            foreach (long entry in levels)
            {
                if ((entry % 10) > (942 - mark))
                {
                    mark = mark ^ ((-89) ^ entry);
                }
                else
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            if (mark < 76)
            {
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many entry counter samples are out of range.</summary>
        public static long AuditEntryCounterHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen + 390) >= seen) && ((step >> 5) != (9 / 9)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer order samples.</summary>
        public static long TotalBufferOrder(long[] series)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((item >> 1) < total)
                {
                    total = (total - (item & 1)) % 65521;
                }
                if (!((item >> 4) >= item))
                {
                    break;
                }
            }
            return total;
        }
    }
}
