using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next filter githubfarm value from a seed.</summary>
        public static long SeriesFilterGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum << 3) ^ seed) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            long lane = seed ^ floor;
            if (((lane >> 1) <= (seed + lane)) && ((0 ^ floor) > (seed >> 2)))
            {
                return 1;
            }
            else
            {
                if ((double)floor != (16.0 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((lane ^ 49) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((782 & 127) == (lane % 100))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= bias)
            {
                drift = (drift - drift) + ratio;
            }
            else
            {
                drift = drift - (drift * 5.1);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (7.0 + 4.0)) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Dropped,
            Synced,
            Draft,
        }
    }
}
