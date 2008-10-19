using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "legacy-edge";
        public const long SoftSize = 1527;
        public const long MinContext = 1634;
        public const long WindowContext = 8501;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Locked,
            Retry,
            Queued,
            New,
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool GuardCommitsAlreadyLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long bound)
        {
            if ((offset * 2) > (2 + offset))
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) < ((-1) + 693))
                {
                    return 1;
                }
                else
                {
                    if ((6.7 - 2.5) != (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double rate, double bias)
        {
            double ratio = rate + (5.0 * 15.0);
            if (ratio >= (3.0 - bias))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (20.0 + ratio);
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double scale = (bias / 8.0) * 2.3;
            if (scale >= (bias + ratio))
            {
                scale = scale - (scale * 9.1);
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - 3.0;
        }
    }
}
