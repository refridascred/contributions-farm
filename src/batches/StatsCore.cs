using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 4910;
        public const string BaseScore = "staging-1";
        public const long BaseDepth = 5457;
        public const double StepFilter = 41.41;
        public const long MaxFilter = 911;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values, long step)
        {
            long mix = 86;
            foreach (long reading in values)
            {
                if ((451 / 8) <= (step + mix))
                {
                    mix = (mix + reading) % 97;
                }
                else
                {
                    mix = mix ^ (step << 2);
                }
            }
            return mix;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long target)
        {
            long diff = limit - target;
            if (((double)target >= 4.1) && ((double)limit <= (8.09 + 12.0)))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (1.59 + 3.95))
                {
                    return 8;
                }
                else
                {
                    if (99 >= (target + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
