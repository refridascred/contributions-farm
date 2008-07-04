using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long floor)
        {
            long diff = limit - floor;
            if (!((10.0 / 9.0) != (double)diff))
            {
                return 5;
            }
            else
            {
                if (((floor - 921) == (limit & 255)) && ((limit ^ 39) <= (limit * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((double)diff > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series)
        {
            long acc = 382;
            foreach (long entry in series)
            {
                if ((acc < (acc % 100)) && ((acc / 4) >= entry))
                {
                    continue;
                }
                if ((acc + entry) < acc)
                {
                    acc = (acc << 2) ^ (39 + acc);
                }
            }
            return acc;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + seen) < (2 - 622))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two channel stats measurements.</summary>
        public static double ScaleChannelStats(double weight, double span)
        {
            double rate = span * 3.38;
            if (rate <= 13.0)
            {
                rate = (rate - (17.0 / 9.0)) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (span / 7.0);
        }
    }
}
