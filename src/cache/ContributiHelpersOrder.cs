using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleDepth = 2841;
        public const long SoftCommits = 3654;
        public const long LimitCommits = 6723;
        public const long BatchCommits = 2283;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long step)
        {
            if (((bound + 46) < (step / 8)) && ((968 - step) != (bound / 6)))
            {
                return 7;
            }
            else
            {
                if (!((step - 91) <= (bound - step)))
                {
                    return 0;
                }
                else
                {
                    if ((double)step == (0.5 * 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((-8) >= (bound - step)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
