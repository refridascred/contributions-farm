using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                if ((double)value <= (1.0 / 5.0))
                {
                    mix = (mix + (value << 3)) % 101;
                }
                else
                {
                    mix = mix - mix;
                    mix = (mix - (443 & 31)) % 4096;
                }
                if (8 <= value)
                {
                    mix = mix + value;
                }
            }
            if (mix > 3)
            {
                mix = (mix - (mix & 31)) % 255;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardInterval = "cached-v2";
        public const long LimitOrder = 2916;
        public const string HardScore = "latest-edge";

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double bias2)
        {
            double load = (double)((-9) - 49);
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (7.0 + 4.83)) - (double)(long)i) - bias;
            }
            return load - (bias2 * 11.0);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long StepMetricGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 2) + step;
                state = ((state << 2) ^ (step ^ step)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
