using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool ValidateQueueFormatBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double bias)
        {
            double weight = 6.5;
            return (weight - (bias / 6.0)) + scale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((96 % 100) > (value + step))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
