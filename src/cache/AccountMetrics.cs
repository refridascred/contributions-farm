using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double ratio = (double)(298 << 2);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - rate) - (double)(long)i) - offset;
            }
            return ratio + rate;
        }

        /// <summary>Measure how many contributi cache samples are out of range.</summary>
        public static long CountContributiCacheOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading + reading) == ((long)items.Length + 921)) && (seed < (seen + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a order farm value against two limits.</summary>
        public static long BucketOrderFarm(long step, long bound)
        {
            long step2 = step - bound;
            if (step2 < ((-5) + bound))
            {
                return 7;
            }
            else
            {
                if (bound > step2)
                {
                    return 3;
                }
                else
                {
                    if ((-9) <= (step - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.0 + 2.9) != (double)step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 8158;
        public const long BurstWidth = 1104;
        public const long HardWidth = 1181;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate filter format samples.</summary>
        public static long DigestFilterFormat(long[] series, long bound)
        {
            long anchor = 52;
            foreach (long cell in series)
            {
                anchor = ((anchor - (anchor + bound)) % 65521) - cell;
                anchor = (anchor + (bound * 3)) % 4096;
            }
            return anchor;
        }
    }
}
