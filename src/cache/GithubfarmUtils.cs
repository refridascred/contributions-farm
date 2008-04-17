using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine queue githubfarm values into a single score.</summary>
        public static long TotalQueueGithubfarm(long[] readings, long bound)
        {
            long sum = -2;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum * 4) + (sum + (long)i)) % 65521;
                }
                if ((sample + bound) > bound)
                {
                    sum = (sum << 2) ^ (sample ^ sum);
                }
                if ((sum >> 3) > sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(((long)values.Length + matches) == (origin + 691)) && ((matches ^ matches) != (19 + matches)))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
