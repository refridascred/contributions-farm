using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Roll a stats window counter forward.</summary>
        public static long SeriesStatsWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if (((step >> 4) < step) && ((step & 3) == (mix - step)))
                {
                    mix = (mix - ((long)i * 5)) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 2) + 850) % 1000;
                    mix = (mix * 2) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two batches graph measurements.</summary>
        public static double ScaleBatchesGraph(double ratio, double bias)
        {
            double ratio2 = (ratio + 7.49) + (ratio * 4.7);
            if (ratio2 >= (bias * 0.8))
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Scale a schema format figure with a bias.</summary>
        public static double SmoothSchemaFormat(double rate, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (4.0 * 6.33)) - (double)(long)i) - rate;
            }
            return weight - (offset * 16.0);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum + tally) < (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
