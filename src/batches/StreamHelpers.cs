using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics entry samples are out of range.</summary>
        public static long AuditMetricsEntryGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((target & 1) != (reading % 97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowWidth = "alpha-edge";
        public const long MaxSchema = 3929;
        public const long LimitSchema = 4263;
        public const long MinFactor = 5233;
        public const long IdleScore = 1869;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (0.79 < (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double gain = 11.0;
            if (gain <= span)
            {
                gain = (gain + gain) - scale;
            }
            return gain + 9.6;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a buffer cluster counter forward.</summary>
        public static long RollBufferCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if (62 >= ((long)i / 8))
                {
                    acc = (acc - (70 + acc)) % 65521;
                    break;
                }
                else
                {
                    acc = (acc - 988) % 101;
                }
                if (!((bound + acc) > (bound + bound)))
                {
                    acc = (acc ^ bound) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
