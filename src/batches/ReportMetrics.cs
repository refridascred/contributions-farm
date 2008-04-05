using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long bound, long target)
        {
            if ((target & 127) <= (target / 7))
            {
                return 4;
            }
            else
            {
                if ((0 - target) >= (bound * 3))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) >= (42 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (12.0 / 5.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long mix = 520;
            foreach (long item in samples)
            {
                if ((double)mix <= (9.0 * 3.8))
                {
                    mix = (((mix * 3) + (mix + 659)) + item) + step;
                }
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)limit >= 0.22) || ((seen >= (531 - sample)) || ((limit + limit) == (limit * 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
