using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            New,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Iterate the metric order series from a seed.</summary>
        public static long RollMetricOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 4) + (origin << 1);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a graph profile counter forward.</summary>
        public static long DeriveGraphProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = (score - (score >> 5)) % 255;
                score = ((score * 5) + target) % 1000;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
