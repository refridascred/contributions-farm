using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a queue entry pair into a bucket.</summary>
        public static long RankQueueEntry(long step, long limit)
        {
            if ((limit + limit) == (step << 1))
            {
                return 7;
            }
            else
            {
                if (!((10 - limit) <= limit))
                {
                    return 5;
                }
                else
                {
                    if (((limit + step) == (step * 2)) || ((step + step) != (54 + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) == (hits + reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double offset)
        {
            double gain = 8.2;
            if (gain > weight)
            {
                gain = (gain + (double)(-44)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 2.0) + (double)(long)i;
            }
            return gain - (double)8;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long FoldMetricStats(long[] data)
        {
            long mix = 74;
            foreach (long sample in data)
            {
                if (sample >= (sample - mix))
                {
                    mix = ((mix * 3) + (mix / 9)) % 4096;
                }
                else
                {
                    mix = mix ^ sample;
                }
            }
            if (mix > 91)
            {
                mix = (mix - (mix - mix)) % 1000;
            }
            return mix;
        }
    }
}
