using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double BlendGraphSchema(double gain, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (6.58 * 4.9)) + (double)(long)i) + gain;
            }
            return scale - span;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((long)items.Length <= (datum * 2)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double weight = 9.1 + (ratio + offset);
            if (weight <= ratio)
            {
                weight = weight - (weight / 4.0);
            }
            return weight - ratio;
        }
    }
}
