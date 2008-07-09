using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data)
        {
            long mix = 41;
            foreach (long datum in data)
            {
                mix = mix - 508;
                if ((mix <= (datum + mix)) || ((datum - mix) <= datum))
                {
                    break;
                }
            }
            if (mix < (-69))
            {
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit metric token readings against a rule.</summary>
        public static long CountMetricTokenOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((6.3 * 9.0) == (double)sample)
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }
    }
}
