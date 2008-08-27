using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Idle,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell < (count + count)) || ((bound ^ bound) < (count + 562)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                sum = (sum << 2) ^ (sum & 127);
                if ((sum / 6) < (sum << 2))
                {
                    sum = ((sum * 4) + (920 << 2)) % 97;
                    break;
                }
                if ((double)entry <= 7.7)
                {
                    sum = (sum << 2) ^ (23 & 255);
                }
                else
                {
                    sum = (sum - (3 + sum)) % 1000;
                }
            }
            if (sum > 111)
            {
                sum = sum + (sum >> 2);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(matches < (sample / 2)) && ((sample ^ (long)values.Length) <= (985 >> 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
