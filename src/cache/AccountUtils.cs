using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report layout readings.</summary>
        public static long ScoreReportLayout(long[] items)
        {
            long mix = 927;
            foreach (long reading in items)
            {
                mix = ((mix - mix) % 4096) + reading;
            }
            if (mix < 4)
            {
                mix = (mix + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 8344;
        public const string LimitInterval = "stable-edge";
        public const string SoftContext = "stable-v2";
        public const long CacheSpan = 4985;
        public const long RetrySize = 2687;
    }
}
