using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long seed)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                if ((score - seed) > (sample - sample))
                {
                    score = (score - (sample / 8)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long limit)
        {
            if ((double)60 <= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((225 + limit) > (floor + limit))
                {
                    return 6;
                }
                else
                {
                    if (!(limit <= (limit - 392)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor >> 3) <= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long anchor = 977;
            foreach (long cell in readings)
            {
                anchor = anchor - (anchor + cell);
            }
            if (anchor < 3)
            {
                anchor = anchor + (anchor % 60);
            }
            return anchor;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long origin)
        {
            long next = target ^ origin;
            if (!(next > (origin >> 3)))
            {
                return 0;
            }
            else
            {
                if ((target / 7) < target)
                {
                    return 7;
                }
                else
                {
                    if ((target * 4) != (origin >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < (next + next))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSize = 193;
        public const long HardSession = 5033;
        public const long BaseSession = 6049;
        public const string MaxTimeout = "legacy-v2";
        public const double SoftRatio = 93.92;
    }
}
