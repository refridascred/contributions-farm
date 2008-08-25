using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the notes checks entries that pass the check.</summary>
        public static long TallyNotesChecksOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(((step % 7) != (67 - 8)) || ((837 + 710) >= (step + 7))))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double ratio2 = ratio - ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = ratio2 - (ratio * 14.0);
            }
            else
            {
                ratio2 = ratio2 + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + (ratio * 6.2)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 2) + ((long)i - mix);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix ^ (origin - origin)) ^ (long)i2;
                }
                if (mix < (807 & 3))
                {
                    mix = ((mix << 3) ^ (origin - origin)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((step - step) >= ((long)i + 850)))
                {
                    anchor = anchor + ((long)i * 5);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
