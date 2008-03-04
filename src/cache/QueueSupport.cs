using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitScore = "primary";
        public const string MaxInterval = "fallback-1";
        public const double MaxCluster = 6.61;

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long target)
        {
            long bound = floor ^ target;
            if ((bound < (bound + 88)) || (bound <= (bound >> 3)))
            {
                return 3;
            }
            else
            {
                if (floor < (88 + target))
                {
                    return 4;
                }
                else
                {
                    if ((target * 3) == ((-1) >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 2) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ (datum * 5)) % 65521;
                if ((datum * 3) <= (datum % 60))
                {
                    score = score - (32 + score);
                    score = (score * 3) + (score * 4);
                }
                else
                {
                    score = ((score << 3) ^ 4) % 1000;
                }
                if ((double)(long)series.Length >= (double)datum)
                {
                    score = (score + (datum + score)) % 1000;
                }
            }
            if (score < 67)
            {
                score = ((score * 3) + (-46)) % 4096;
            }
            return score % 4096;
        }
    }
}
