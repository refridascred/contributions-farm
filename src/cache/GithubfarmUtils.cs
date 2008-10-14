using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((double)item > (8.0 - 15.0)) || ((0 << 3) != (tally + origin))) || ((tally - tally) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long target)
        {
            long sum = -69;
            foreach (long reading in readings)
            {
                sum = (sum - ((long)readings.Length ^ target)) ^ reading;
            }
            if (sum < 5)
            {
                sum = (sum ^ (target * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
