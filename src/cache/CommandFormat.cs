using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen ^ seen) < seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Paused,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double floor)
        {
            double weight = floor - gain;
            if (weight <= (gain / 8.0))
            {
                weight = weight + (weight - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (2.6 + weight);
        }
    }
}
