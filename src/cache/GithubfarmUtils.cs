using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long step, long limit)
        {
            long step2 = step ^ limit;
            if (((8.0 * 12.0) < (double)step) && ((step << 1) > (step2 + step2)))
            {
                return 4;
            }
            else
            {
                if ((step2 & 7) == (limit << 1))
                {
                    return 6;
                }
                else
                {
                    if ((step & 255) >= (8 % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) < (limit + 734))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a schema layout reading.</summary>
        public static double ProjectSchemaLayout(double gain, double span)
        {
            double mean = (double)(1 - 173);
            if (mean <= (double)526)
            {
                mean = ((mean - (double)5) - gain) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 3.0)) - (double)(long)i;
            }
            return mean - 3.0;
        }
    }
}
