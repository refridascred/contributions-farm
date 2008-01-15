using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double ratio, double span)
        {
            double mean = 7.44;
            if (mean > span)
            {
                mean = (mean + mean) - ratio;
            }
            return mean - (double)6;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double weight, double span)
        {
            double ratio = (3.28 * 7.15) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)(long)i) + span;
            }
            return ratio + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepDepth = "alpha-edge";
        public const string LimitScore = "alpha-edge";
        public const double MinScore = 56.62;
        public const long StepWindow = 3607;

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long step)
        {
            long cur = target ^ step;
            if (((double)target == (16.0 / 6.0)) || ((double)target != (0.8 + 9.0)))
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (5 << 1))
                {
                    return 5;
                }
                else
                {
                    if (9 <= (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) <= (step << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long anchor = 5;
            foreach (long reading in data)
            {
                anchor = (anchor << 3) ^ reading;
                if (((anchor + anchor) <= (anchor - anchor)) && (((long)data.Length << 1) < ((-8) / 8)))
                {
                    break;
                }
            }
            if (anchor < (-910))
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long origin, long step)
        {
            long offset = origin ^ step;
            if (((7.64 / 7.0) > (double)offset) && (7 < (7 + offset)))
            {
                return 8;
            }
            else
            {
                if ((offset + step) >= (origin + 99))
                {
                    return 4;
                }
                else
                {
                    if (((step - offset) != (offset & 15)) || (offset < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= 6.3)
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
        }
    }
}
