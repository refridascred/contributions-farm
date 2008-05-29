using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metric profile series from a seed.</summary>
        public static long DeriveMetricProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score < (1.0 - 7.0))
                {
                    score = ((score * 3) + target) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((-1) + score)) % 1000;
                }
                score = (score << 3) ^ (target - 111);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit window tools readings against a rule.</summary>
        public static long AuditWindowToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((7.24 - 6.0) <= (double)seen)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ step) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long score = -141;
            foreach (long sample in data)
            {
                score = (score + (long)data.Length) % 255;
                score = score - (sample % 5);
            }
            if (score < 2)
            {
                score = score + step;
            }
            return score % 4096;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many commits cache samples are out of range.</summary>
        public static long MeasureCommitsCacheMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((origin + origin) > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
