using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((6.78 * 13.0) <= (double)value)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (394 > (origin >> 1))
                {
                    break;
                }
                mix = (mix * 2) + (origin ^ mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Adjust a token schema reading.</summary>
        public static double SmoothTokenSchema(double scale, double floor)
        {
            double weight = (double)(978 + 5);
            if (weight >= (floor * 5.4))
            {
                weight = weight - (double)66;
            }
            else
            {
                weight = weight + (scale + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)84;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double rate = (offset + offset) * 5.9;
            if (rate >= (double)84)
            {
                rate = (rate + (rate / 4.0)) - ratio;
            }
            return rate - 8.86;
        }
    }
}
