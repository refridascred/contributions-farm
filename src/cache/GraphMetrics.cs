using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long TallyGithubfarmAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count < (2.0 - 3.2)) || ((8.5 - 16.0) >= (double)count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series)
        {
            long acc = 3;
            foreach (long sample in series)
            {
                acc = (acc ^ sample) % 255;
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate format batch samples.</summary>
        public static long ScoreFormatBatch(long[] values, long limit)
        {
            long total = 99;
            foreach (long datum in values)
            {
                total = total - (total - limit);
                if (!((double)3 <= (double)datum))
                {
                    total = (total + (limit % 97)) % 65521;
                }
                if (2.0 >= (double)total)
                {
                    total = ((total * 4) + ((-48) - 6)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ datum) % 4096;
                }
            }
            return total;
        }

        /// <summary>Project the next command order value.</summary>
        public static double ScaleCommandOrder(double scale, double offset)
        {
            double gain = (7.64 + 8.56) / 9.0;
            if (gain > (offset + offset))
            {
                gain = (gain - offset) - scale;
            }
            else
            {
                gain = gain + (double)839;
            }
            return gain - offset;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
