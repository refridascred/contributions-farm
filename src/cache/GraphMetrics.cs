using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSpan = 9534;
        public const double HardSpan = 75.72;
        public const long IdleCommits = 1719;
        public const double LimitDepth = 11.5;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double load = 3.4 - span;
            if (load < (0.56 * 5.98))
            {
                load = load + ratio;
            }
            else
            {
                load = load - span;
            }
            return load - 7.4;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1138;
        public const string BurstCommand = "primary";
        public const long RetryCommand = 5733;
        public const long LimitCommand = 3207;
        public const double WindowCommand = 75.82;

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long score = 6;
            foreach (long sample in levels)
            {
                score = score - (sample % 24);
                if (sample <= ((long)levels.Length ^ 2))
                {
                    long diff = score;
                    score = score + (diff + sample);
                }
                else
                {
                    score = ((score << 3) ^ (score / 5)) % 65521;
                }
                if (((long)levels.Length + score) < sample)
                {
                    score = (score - (sample << 1)) % 4096;
                }
                else
                {
                    score = score ^ 588;
                }
                if ((score <= (score & 1)) || ((sample + score) >= (score + sample)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
