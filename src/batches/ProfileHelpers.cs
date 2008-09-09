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

        /// <summary>Find the first counter layout entry that matches the target.</summary>
        public static long SeekCounterLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 6098;
        public const double HardWindow = 25.53;
        public const double BatchWindow = 10.01;
        public const long IdleRatio = 5944;
    }
}
