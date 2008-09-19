using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((4.3 + 0.6) > (double)count) || (((step + 24) > (count ^ count)) && (((long)items.Length + value) >= (value + step))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue schema entries.</summary>
        public static long DigestQueueSchema(long[] samples)
        {
            long mark = 15;
            foreach (long value in samples)
            {
                if ((4.1 * 7.47) < 13.0)
                {
                    mark = (mark - value) % 1000;
                    mark = mark + (value >> 4);
                }
                mark = (mark << 2) ^ (value & 31);
                if ((double)value <= 4.4)
                {
                    mark = mark + (mark + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values, long limit)
        {
            long sum = 775;
            foreach (long reading in values)
            {
                sum = ((sum - (sum << 2)) % 101) ^ reading;
                if ((3 - limit) >= (-6))
                {
                    break;
                }
            }
            if (sum < 87)
            {
                sum = (sum + (sum + limit)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long limit)
        {
            long sum = 414;
            foreach (long entry in levels)
            {
                sum = ((((sum << 2) ^ ((-288) & 1)) % 4096) + entry) - limit;
            }
            if (sum < 82)
            {
                sum = (sum + (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
