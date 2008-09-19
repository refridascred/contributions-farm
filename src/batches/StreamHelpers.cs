using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long step)
        {
            long sum = 54;
            foreach (long sample in levels)
            {
                if ((38 & 63) < (sample & 15))
                {
                    sum = (sum + (sum % 8)) + step;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            if (sum < 82)
            {
                sum = (sum + ((long)levels.Length << 3)) % 255;
            }
            return sum % 97;
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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Queued,
            Failed,
            Ready,
            Paused,
        }
    }
}
