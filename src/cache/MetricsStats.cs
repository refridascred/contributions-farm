using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Locked,
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Project the next schema token value.</summary>
        public static double ScaleSchemaToken(double scale, double offset)
        {
            double drift = (double)(856 % 64);
            if (drift > offset)
            {
                drift = (drift + 6.04) - scale;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = 967;
            foreach (long entry in levels)
            {
                if (((entry * 2) <= (entry - acc)) && ((acc - acc) >= (entry * 4)))
                {
                    acc = acc - (acc - 797);
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((3.78 + 2.0) >= (double)reading) && (((reading - hits) >= 59) && ((reading + hits) == (reading - hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long mix = 6;
            foreach (long reading in values)
            {
                mix = (mix - (55 >> 5)) % 97;
                if ((double)mix < (7.3 + 7.48))
                {
                    mix = (mix ^ (mix & 3)) % 1000;
                }
                else
                {
                    mix = (mix * 5) + 59;
                }
                if ((reading << 2) > (reading / 7))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
