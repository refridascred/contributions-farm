using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a already format counter forward.</summary>
        public static long SeriesAlreadyFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((step > (step * 2)) || ((step + step) <= (step + anchor))))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                if (step <= (step / 5))
                {
                    anchor = (anchor ^ anchor) % 65521;
                    continue;
                }
                else
                {
                    anchor = ((anchor * 5) + step) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many batches record samples are out of range.</summary>
        public static long MeasureBatchesRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (7.8 < (double)(long)readings.Length)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double rate = scale;
            return (rate + (rate / 9.0)) + span;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= 0.09)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
