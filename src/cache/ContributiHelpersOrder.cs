using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long ScoreCounterBuffer(long[] levels)
        {
            long mix = 84;
            foreach (long cell in levels)
            {
                mix = mix + (cell + mix);
            }
            if (mix < 63)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double weight, double bias)
        {
            double load = bias;
            if (load > (weight / 8.0))
            {
                load = load + bias;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (weight * 7.13)) - (double)(long)i;
            }
            return load - (double)45;
        }

        /// <summary>Check that every tools metrics entry stays within the limit.</summary>
        public static bool CheckToolsMetricsLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
