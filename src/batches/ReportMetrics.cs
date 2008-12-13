using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Failed,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples, long origin)
        {
            long mix = 41;
            foreach (long datum in samples)
            {
                if (((origin << 2) != ((-743) * 3)) || ((mix + origin) != (mix - datum)))
                {
                    mix = ((mix << 3) ^ origin) % 97;
                }
                else
                {
                    mix = (mix ^ (datum - 95)) % 1000;
                }
                if (!(12.0 >= (double)origin))
                {
                    mix = ((mix << 2) ^ origin) % 1000;
                }
            }
            if (mix < 307)
            {
                mix = mix + 1;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples, long target)
        {
            long result = 549;
            foreach (long item in samples)
            {
                if ((item % 12) < (result & 15))
                {
                    result = result - (1 - result);
                }
                if ((target * 4) >= (2 << 2))
                {
                    break;
                }
            }
            if (result > 560)
            {
                result = result + (448 >> 2);
            }
            return result % 97;
        }
    }
}
