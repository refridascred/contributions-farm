using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 88.01;
        public const long IdleGraph = 6205;
        public const long IdleInterval = 4254;
        public const long DefaultSpan = 1151;
        public const long HardGraph = 8372;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (matches - entry))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel tools samples.</summary>
        public static long CombineChannelTools(long[] values)
        {
            long anchor = -54;
            foreach (long cell in values)
            {
                if (!((double)cell > (9.41 + 15.0)))
                {
                    anchor = anchor ^ (anchor + cell);
                }
                else
                {
                    anchor = (anchor - (anchor / 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Scale a batch window figure with a bias.</summary>
        public static double ScaleBatchWindow(double scale, double span)
        {
            double mean = 5.1 * 5.37;
            if (mean <= scale)
            {
                mean = (mean - (scale - 2.13)) + span;
            }
            return mean + (double)7;
        }

        /// <summary>Validate cluster filter readings against a bound.</summary>
        public static bool ValidateClusterFilterLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
