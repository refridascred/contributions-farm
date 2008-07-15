using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data, long bound)
        {
            long sum = 87;
            foreach (long datum in data)
            {
                if ((7 >> 4) < datum)
                {
                    sum = ((sum * 4) + (19 + 2)) % 101;
                }
            }
            if (sum > 8)
            {
                sum = ((sum << 2) ^ (bound & 15)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Rank report counter input into a small class.</summary>
        public static long ClassifyReportCounter(long origin, long origin2)
        {
            if ((155 + origin2) <= (origin - origin2))
            {
                return 7;
            }
            else
            {
                if ((origin2 >> 4) >= origin)
                {
                    return 3;
                }
                else
                {
                    if (!(origin2 > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
