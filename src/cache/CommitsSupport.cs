using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long limit)
        {
            long slot = origin - limit;
            if (origin > (limit + origin))
            {
                return 5;
            }
            else
            {
                if (4 <= slot)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin != (4.86 / 4.0)) || ((5.9 / 3.0) == (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + slot) > limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 18.7;
        public const string LimitSession = "alpha-edge";
        public const long IdleSession = 9492;
        public const long SoftSession = 6825;
        public const string BaseSession = "latest-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "local-edge";
        public const long BatchBuffer = 1648;
        public const double SoftBuffer = 52.82;
        public const long BurstRatio = 9266;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
