using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels)
        {
            long anchor = 414;
            foreach (long datum in levels)
            {
                if (datum <= (datum * 2))
                {
                    anchor = (anchor ^ (datum >> 3)) % 97;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 8) <= (cell << 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster account readings.</summary>
        public static long TallyClusterAccount(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                sum = ((sum << 3) ^ (618 >> 5)) % 65521;
                if ((sum >> 5) < (datum % 10))
                {
                    sum = ((sum << 2) ^ (sum & 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long CountRecordMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (73 <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((20.0 / 3.0) == (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
