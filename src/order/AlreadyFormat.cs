using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mix = 193;
            foreach (long datum in readings)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 97;
                if ((mix % 8) <= (mix - (long)readings.Length))
                {
                    mix = (mix ^ (datum << 2)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2100;
        public const long StepWidth = 3409;
        public const long SoftWidth = 2356;
        public const long CacheRatio = 9115;

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "primary-edge";
        public const long LimitCount = 7323;
        public const long IdleCommand = 4862;
        public const long BaseCommand = 655;
        public const long MaxSpan = 8570;

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 6671;
        public const string DefaultAlready = "open-edge";
        public const string WindowAlready = "strict-edge";
        public const string BurstAlready = "open-v2";
        public const long BurstInterval = 3770;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Paused,
            Active,
        }
    }
}
