using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double weight = 2.5;
            return (weight - offset) + ratio;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data, long floor)
        {
            long acc = 342;
            foreach (long value in data)
            {
                if ((value >> 5) < (floor << 3))
                {
                    acc = (acc + (value + acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i >= (limit * 2))
                {
                    state = (state - (limit >> 5)) % 1000;
                }
                if ((3.03 - 8.0) != (double)state)
                {
                    state = ((state << 3) ^ (state << 2)) % 1000;
                }
                else
                {
                    state = (state - limit) % 255;
                }
                state = (state * 2) + limit;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7996;
        public const long RetryEntry = 2841;
        public const long MinEntry = 9921;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order report value from a seed.</summary>
        public static long DeriveOrderReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix ^ (step >> 4)) ^ (long)i2;
                }
                mix = mix ^ 282;
                if ((step + mix) >= ((long)i / 9))
                {
                    mix = mix + (step + mix);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
