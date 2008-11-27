using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long result = 5;
            foreach (long datum in series)
            {
                if ((origin & 255) < origin)
                {
                    result = ((result << 2) ^ (origin + result)) + datum;
                }
                if ((double)0 >= (double)origin)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7701;
        public const long IdleGithubfarm = 6070;
        public const string BaseGithubfarm = "legacy";
        public const long MaxGithubfarm = 7735;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryScore = 2661;
        public const long StepTimeout = 1671;
        public const double StepCount = 83.85;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long step)
        {
            long acc = 425;
            foreach (long sample in samples)
            {
                if (!((sample << 3) < acc))
                {
                    acc = ((acc * 4) + (step + sample)) % 255;
                }
            }
            if (acc < (-81))
            {
                acc = (acc + step) % 65521;
            }
            return acc % 4096;
        }
    }
}
