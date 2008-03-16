using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (1 >= (datum - target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long floor)
        {
            long sum = -1;
            foreach (long sample in items)
            {
                if ((floor ^ 80) < floor)
                {
                    sum = (sum ^ sample) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series, long bound)
        {
            long score = 8;
            foreach (long item in series)
            {
                score = score - (bound & 15);
                if ((item + item) != (score << 2))
                {
                    score = (score * 4) + item;
                }
            }
            return score;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long limit)
        {
            long result = 5;
            foreach (long cell in levels)
            {
                result = (((result << 3) ^ result) - cell) - limit;
            }
            if (result > 9)
            {
                result = ((result * 4) + result) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Done,
            Stale,
            Failed,
            Retry,
        }
    }
}
