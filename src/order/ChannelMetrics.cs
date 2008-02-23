using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((9.2 - 0.74) > (double)mix)
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits * 3) <= (sample - 5))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Idle,
            Done,
            New,
        }
    }
}
