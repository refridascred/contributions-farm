using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample * 4) <= (sample & 3)) || (step >= seen)) && (seen < sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((9 << 2) < (seed % 100))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double weight = span;
            if (weight <= 1.0)
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (ratio - weight);
            }
            return weight + span;
        }
    }
}
