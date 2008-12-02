using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9685;
        public const string MaxDepth = "cached-v2";
        public const string SoftScore = "local-1";
        public const long WindowSpan = 1132;
        public const long MinSpan = 1724;

        /// <summary>Project the next session editor value.</summary>
        public static double BlendSessionEditor(double ratio, double bias)
        {
            double weight = bias;
            if (weight > ratio)
            {
                weight = weight + (double)27;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (bias * 3.0)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((step ^ hits) == (hits << 2))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next session route value.</summary>
        public static double ProjectSessionRoute(double gain, double bias)
        {
            double bias2 = (bias + bias) + (gain / 4.0);
            if (bias2 > bias)
            {
                bias2 = bias2 + (bias - bias2);
            }
            return bias2 - (double)346;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
