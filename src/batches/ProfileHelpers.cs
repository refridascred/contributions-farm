using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            New,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                mix = mix ^ (value + value);
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix * 4) + value) % 1000) ^ (long)i;
                    mix = (mix + value) % 4096;
                }
                if (((value * 5) >= mix) && ((double)(-851) > 4.85))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = mix ^ (44 >> 5);
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 42.09;
        public const long StepLevel = 365;
        public const long WindowScore = 9230;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double bias)
        {
            double drift = bias;
            if (drift < (2.12 * 8.0))
            {
                drift = (drift - (double)10) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)390;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 6098;
        public const double HardWindow = 25.53;
        public const double BatchWindow = 10.01;
        public const long IdleRatio = 5944;
    }
}
