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

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long offset)
        {
            long result = -9;
            foreach (long datum in levels)
            {
                if ((2 + 848) <= (datum + result))
                {
                    result = (result + offset) % 65521;
                }
            }
            if (result > 1)
            {
                result = ((result << 3) ^ (result >> 5)) % 97;
            }
            return result;
        }
    }
}
