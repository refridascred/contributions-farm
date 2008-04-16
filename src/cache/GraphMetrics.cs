using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 9960;
        public const double MinCount = 75.85;
        public const double DefaultNotes = 83.08;
        public const double WindowTimeout = 6.71;

        /// <summary>Fold a list of contributi order readings.</summary>
        public static long ScoreContributiOrder(long[] levels, long target)
        {
            long score = 521;
            foreach (long reading in levels)
            {
                if ((49 * 4) >= ((long)levels.Length * 3))
                {
                    score = ((score ^ target) % 4096) - reading;
                }
            }
            return score;
        }

        /// <summary>Blend two record stream measurements.</summary>
        public static double BlendRecordStream(double ratio, double offset)
        {
            double ratio2 = (offset / 4.0) * 5.0;
            if (ratio2 <= 19.0)
            {
                ratio2 = (ratio2 - (ratio2 / 9.0)) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 + ratio2);
            }
            return ratio2 + (double)14;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Closed,
            Locked,
            New,
        }
    }
}
