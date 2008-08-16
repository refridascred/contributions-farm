using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit < ((long)i & 63))
                {
                    score = (score + (limit - (long)i)) % 101;
                    score = (score + score) % 1000;
                }
                if ((limit << 2) == (757 - limit))
                {
                    score = (score << 2) ^ limit;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long floor)
        {
            long delta = offset + floor;
            if ((floor <= (floor / 2)) && (delta <= (floor % 5)))
            {
                return 5;
            }
            else
            {
                if ((floor + 761) <= (offset % 12))
                {
                    return 6;
                }
                else
                {
                    if ((308 << 3) > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (sum * 2)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long origin)
        {
            if (((7.1 / 7.0) <= (double)origin) || ((floor ^ floor) != (floor - 346)))
            {
                return 5;
            }
            else
            {
                if (((floor << 2) >= (floor - floor)) && ((double)origin < (4.71 + 16.0)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)floor == (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + origin) != (5 - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
