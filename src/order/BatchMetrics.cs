using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long step)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((double)mix > (17.0 / 7.0))
                {
                    mix = ((mix << 2) ^ (mix - step)) - sample;
                }
            }
            if (mix < 1)
            {
                mix = (mix ^ (step % 100)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 7492;
        public const string SoftInterval = "strict";
        public const long StepLevel = 1471;
        public const long MaxWidth = 5557;
        public const string CacheToken = "cached-edge";

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double rate, double offset)
        {
            double load = rate;
            if (load > (load * 3.92))
            {
                load = load - (offset - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - bound) >= (bound - bound)) && (((hits - (long)readings.Length) < (hits + reading)) && ((65 + bound) > ((long)readings.Length << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up contributi commits samples.</summary>
        public static long PairContributiCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
