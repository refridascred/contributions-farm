using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 7170;
        public const long BaseSpan = 3865;
        public const long StepCount = 6764;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings, long target)
        {
            long total = 543;
            foreach (long sample in readings)
            {
                if ((total * 5) > (target + target))
                {
                    total = (total ^ target) % 101;
                }
                else
                {
                    total = (total << 3) ^ (sample % 5);
                }
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(step < (seen / 7)) || (((seen % 3) < (step % 2)) && ((seen / 9) == (seen - 26))))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "staging-v2";
        public const long HardFactor = 4206;
        public const long BaseWidth = 7250;
    }
}
