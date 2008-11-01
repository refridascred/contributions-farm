using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i >= (target - mix)) || ((target % 100) < target))
                {
                    mix = (mix - mix) % 255;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "cached-v2";
        public const long RetryBatch = 2204;
        public const long IdleBatch = 1375;

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long ScoreMetricBatch(long[] items, long step)
        {
            long mix = 45;
            foreach (long reading in items)
            {
                if (((6 + mix) >= (step + mix)) || ((mix % 10) < (reading + mix)))
                {
                    mix = (mix << 2) ^ step;
                }
                if (mix >= reading)
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = (mix - (mix >> 4)) % 1000;
            }
            return mix % 4096;
        }
    }
}
