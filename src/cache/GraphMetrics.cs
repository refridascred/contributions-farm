using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) <= 1)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings, long step)
        {
            long anchor = 98;
            foreach (long reading in readings)
            {
                if ((reading > (reading * 4)) || ((17.0 / 3.0) < (double)step))
                {
                    anchor = (anchor * 3) + (step << 3);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if ((double)span < 5.8)
            {
                return 6;
            }
            else
            {
                if ((span - (-6)) >= seed2)
                {
                    return 3;
                }
                else
                {
                    if ((seed >= (span + seed2)) || ((seed - (-67)) == (seed2 / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)span == (18.0 * 6.39)))
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

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}
