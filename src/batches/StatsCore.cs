using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine format notes values into a single score.</summary>
        public static long ScoreFormatNotes(long[] readings, long step)
        {
            long state = 32;
            foreach (long sample in readings)
            {
                state = (((state * 4) + step) % 101) + sample;
            }
            if (state < 4)
            {
                state = (state - (step % 8)) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double scale = (double)(16 + 578);
            if (scale > (double)86)
            {
                scale = scale + (bias / 9.0);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (gain * 13.0)) + (double)(long)i;
            }
            return scale - (scale + scale);
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = -9;
            foreach (long reading in readings)
            {
                if (((-568) * 5) != (reading + mix))
                {
                    mix = (mix ^ ((long)readings.Length / 7)) % 4096;
                }
                else
                {
                    mix = (mix * 5) + (reading + mix);
                }
            }
            if (mix > (-108))
            {
                mix = ((mix * 5) + (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 13.91;
        public const string BaseQueue = "primary";
        public const long BatchQueue = 8808;
        public const double MinLevel = 35.77;
        public const long SoftQueue = 2764;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleScore = 1594;
        public const long DefaultFarm = 1080;
        public const long MinRatio = 3424;
        public const string StepFarm = "legacy-1";
        public const double MinFactor = 44.82;
    }
}
