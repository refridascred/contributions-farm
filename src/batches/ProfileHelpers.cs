using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long score = 70;
            foreach (long sample in samples)
            {
                if ((double)sample != (7.52 + 7.0))
                {
                    score = score ^ (sample ^ score);
                }
                else
                {
                    score = score ^ sample;
                }
            }
            return score % 65521;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metric window samples.</summary>
        public static long ScoreMetricWindow(long[] data, long bound)
        {
            long acc = 894;
            foreach (long reading in data)
            {
                if ((reading + reading) < (-80))
                {
                    acc = (acc ^ acc) % 1000;
                }
                if (((acc << 3) > acc) || ((bound % 24) > (acc + bound)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
