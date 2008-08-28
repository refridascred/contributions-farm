using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long floor)
        {
            long mix = 70;
            foreach (long sample in levels)
            {
                if (mix <= 472)
                {
                    mix = ((mix * 3) + sample) % 101;
                }
            }
            if (mix < 246)
            {
                mix = (mix - (floor + floor)) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples, long floor)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                if ((-70) >= (7 + mark))
                {
                    mark = (((mark * 4) + mark) - value) - floor;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardSize = 30.28;
        public const long StepLayout = 5181;
        public const double HardLayout = 58.93;
        public const long SoftLayout = 7647;

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 757;
        public const double RetryFactor = 55.86;
        public const long BaseCommand = 2871;
        public const long IdleCommand = 4674;
    }
}
