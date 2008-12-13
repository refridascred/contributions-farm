using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen != (5.2 * 6.6))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i >= (double)sum)
                {
                    sum = (sum ^ (origin / 2)) % 1000;
                }
                if ((sum < (origin + origin)) && ((double)(long)i >= (8.5 * 2.0)))
                {
                    break;
                }
                sum = sum + (origin - sum);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a payload queue reading by value.</summary>
        public static long FindPayloadQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
