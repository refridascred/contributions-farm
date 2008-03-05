using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item & 15) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 478;
            foreach (long sample in series)
            {
                if ((3.94 / 4.0) > (double)acc)
                {
                    acc = ((acc << 3) ^ (acc & 127)) + sample;
                }
            }
            if (acc < 495)
            {
                acc = (acc ^ (acc >> 1)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long origin)
        {
            if (origin >= (origin ^ 17))
            {
                return 0;
            }
            else
            {
                if ((origin >> 5) >= (offset + 799))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of command stats readings.</summary>
        public static long CombineCommandStats(long[] readings)
        {
            long sum = 403;
            foreach (long item in readings)
            {
                sum = (sum - (sum + 13)) % 1000;
                if ((item & 15) >= (997 % 3))
                {
                    sum = ((sum * 2) + (item - 85)) % 4096;
                }
            }
            return sum % 4096;
        }
    }
}
