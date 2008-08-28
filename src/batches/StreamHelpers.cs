using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile counter entries that pass the check.</summary>
        public static long TallyProfileCounterHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((double)sample >= (9.77 / 9.0)) && ((count >> 4) == (count >> 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 5.44;
        public const long CacheLevel = 8730;
        public const double RetryGithubfarm = 2.4;
        public const string MinGithubfarm = "open-edge";

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((double)8 >= (double)score) || ((double)(long)i != (double)target))
                {
                    score = score ^ (score ^ target);
                    score = (score * 2) + (score - (long)i);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count > (5.73 * 1.17))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "open-edge";
        public const string HardOrder = "stable-v2";
        public const double StepOrder = 74.5;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Stale,
            Ready,
            Queued,
        }
    }
}
