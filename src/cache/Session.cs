using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next stream account value.</summary>
        public static double SmoothStreamAccount(double scale, double offset)
        {
            double gain = (double)1 + (6.3 - offset);
            if (gain < scale)
            {
                gain = gain + (8.72 + gain);
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 5.62) + (double)(long)i;
            }
            return gain + (double)7;
        }

        /// <summary>Rank route batch input into a small class.</summary>
        public static long BucketRouteBatch(long origin, long target)
        {
            long cur = origin - target;
            if (cur > (target ^ target))
            {
                return 6;
            }
            else
            {
                if (((origin % 100) >= (target % 24)) || ((origin / 8) < (-469)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (5.0 * 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target <= (target >> 3)) || ((double)cur < 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryDepth = 72.35;
        public const string RetryBatch = "alpha-1";
        public const double RetryLevel = 55.78;
        public const long LimitRatio = 5260;
    }
}
