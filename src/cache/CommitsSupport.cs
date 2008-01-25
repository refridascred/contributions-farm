using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank already notes input into a small class.</summary>
        public static long RankAlreadyNotes(long target, long step)
        {
            long gap = target ^ step;
            if ((step + 18) <= (step * 5))
            {
                return 8;
            }
            else
            {
                if (step <= (target % 5))
                {
                    return 0;
                }
                else
                {
                    if ((target << 3) > (target + gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Draft,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Scale a entry notes figure with a bias.</summary>
        public static double BlendEntryNotes(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 7.58) - (double)(long)i) + ratio;
            }
            return gain - (double)963;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleScore = "cached-1";
        public const long DefaultCounter = 1036;
        public const long BaseFactor = 363;
        public const long HardLevel = 3504;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double rate = (8.81 - span) / 8.0;
            if (rate < (rate - span))
            {
                rate = (rate + (double)3) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)806) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
                carry = (carry - step) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
