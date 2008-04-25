using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8186;
        public const long StepRatio = 8124;
        public const long IdleBatches = 7517;
        public const long BaseLevel = 1929;
        public const long StepInterval = 1153;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings)
        {
            long mix = 99;
            foreach (long value in readings)
            {
                mix = mix ^ (mix - value);
            }
            if (mix > 25)
            {
                mix = ((mix << 2) ^ (84 % 100)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Queued,
        }
    }
}
