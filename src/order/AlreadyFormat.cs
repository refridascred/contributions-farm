using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((double)score == (4.49 - 8.0)) || (floor < ((long)i & 3)))
                {
                    score = (score ^ (score - score)) % 101;
                }
                score = ((score * 5) + (score >> 1)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long target)
        {
            long acc = 731;
            foreach (long item in readings)
            {
                if (((double)item > 3.69) || ((target ^ 35) <= target))
                {
                    acc = (acc + (acc >> 3)) % 65521;
                }
                else
                {
                    acc = (acc * 3) + item;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 3) ^ target) % 101;
            }
            return acc % 97;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long origin)
        {
            long lane = limit + origin;
            if (origin > (lane - lane))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) > 10)
                {
                    return 0;
                }
                else
                {
                    if ((4 & 63) == (limit + origin))
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

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long origin)
        {
            long diff = limit + origin;
            if ((diff << 2) <= (357 & 255))
            {
                return 0;
            }
            else
            {
                if ((diff + diff) == (diff % 5))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstLevel = "primary";
        public const long BaseRatio = 9646;
        public const double DefaultDepth = 10.07;
        public const long SoftLevel = 5944;
    }
}
