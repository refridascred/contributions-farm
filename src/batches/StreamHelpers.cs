using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series, long floor)
        {
            long result = 99;
            foreach (long datum in series)
            {
                if (6.0 < (double)result)
                {
                    result = ((result + (69 ^ (-74))) - datum) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long bound)
        {
            long cur = origin ^ bound;
            if (((cur / 6) > (bound << 2)) && (cur <= (bound << 3)))
            {
                return 3;
            }
            else
            {
                if (((8.0 / 3.0) < (double)origin) || ((origin / 2) > (313 - bound)))
                {
                    return 7;
                }
                else
                {
                    if (!((cur & 3) > (cur / 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin ^ bound) >= (origin - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long floor, long step)
        {
            long prev = floor + step;
            if ((75 >> 5) < (step / 8))
            {
                return 3;
            }
            else
            {
                if ((step + floor) < (floor + step))
                {
                    return 8;
                }
                else
                {
                    if ((step + (-62)) <= (floor << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((26 & 255) < prev)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
