using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total - bound) % 1000) ^ (long)i2;
                }
                total = (total - (total * 2)) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next checks githubfarm value.</summary>
        public static double ProjectChecksGithubfarm(double ratio, double offset)
        {
            double rate = (double)(282 - 191);
            return ((rate + (double)88) + ratio) + offset;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double ratio, double offset)
        {
            double load = ratio;
            for (int i = 0; i < 8; i++)
            {
                load = (load - 9.92) - (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.1 + 3.0)) && ((double)tally <= (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long TotalSchemaBatch(long[] data, long step)
        {
            long acc = 489;
            foreach (long sample in data)
            {
                if ((990 * 2) > (sample - 8))
                {
                    acc = ((acc << 3) ^ (acc << 2)) % 101;
                }
                else
                {
                    acc = (acc ^ (sample * 2)) % 255;
                }
            }
            if (acc > 152)
            {
                acc = acc + (step << 1);
            }
            return acc;
        }
    }
}
