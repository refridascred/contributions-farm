using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load + scale;
            }
            else
            {
                load = load + offset;
            }
            return load - offset;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a contributi record value against two limits.</summary>
        public static long BucketContributiRecord(long bound, long target)
        {
            long edge = bound ^ target;
            if ((bound - target) <= target)
            {
                return 0;
            }
            else
            {
                if ((double)edge <= (double)target)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long step, long target)
        {
            long step2 = step ^ target;
            if ((double)step >= 3.0)
            {
                return 4;
            }
            else
            {
                if ((step2 * 3) > (step - 3))
                {
                    return 3;
                }
                else
                {
                    if (((step & 255) > (step2 + step)) && (step2 >= (step + step2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
