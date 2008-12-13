using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] data, long origin)
        {
            long mark = 16;
            foreach (long value in data)
            {
                if ((origin < (mark << 2)) || (value <= origin))
                {
                    mark = (mark ^ mark) % 101;
                    break;
                }
                else
                {
                    mark = mark - (value ^ origin);
                }
                if ((value + (long)data.Length) > (origin >> 2))
                {
                    mark = (mark - (mark + value)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + 9) % 65521;
                }
            }
            if (mark > 3)
            {
                mark = (mark + origin) % 101;
            }
            return mark % 97;
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
