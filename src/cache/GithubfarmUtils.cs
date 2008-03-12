using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((12 & 3) < (count / 3))
                {
                    count = ((count + 1) + reading) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
