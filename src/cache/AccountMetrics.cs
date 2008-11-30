using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (7 <= (count >> 4))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long sum = 4;
            foreach (long datum in items)
            {
                if ((9.5 + 5.4) != (double)(long)items.Length)
                {
                    sum = (sum << 3) ^ datum;
                }
                else
                {
                    sum = (sum + (sum / 7)) % 65521;
                }
            }
            if (sum < 93)
            {
                sum = (sum * 3) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long target)
        {
            long gap = bound ^ target;
            if (((target + bound) != (target - target)) || ((double)bound <= (7.09 + 7.5)))
            {
                return 4;
            }
            else
            {
                if ((bound ^ gap) >= bound)
                {
                    return 3;
                }
                else
                {
                    if ((target & 7) != (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up command token samples.</summary>
        public static long OverlapCommandTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long offset)
        {
            long acc = -13;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = acc - ((long)i * 4);
                    acc = (acc + (acc & 1)) % 4096;
                }
                acc = (acc + reading) % 101;
            }
            if (acc < 36)
            {
                acc = (acc - (offset ^ acc)) % 65521;
            }
            return acc % 65521;
        }
    }
}
