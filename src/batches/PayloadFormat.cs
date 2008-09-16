using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "latest";
        public const long HardSupport = 2588;
        public const string RetryCount = "alpha-v2";
        public const long BurstRatio = 900;
        public const long WindowSupport = 2301;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((step * 5) == (419 >> 2))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series, long target)
        {
            long mix = 53;
            foreach (long value in series)
            {
                if (!((double)target >= 19.0))
                {
                    mix = ((mix * 5) + value) % 65521;
                }
                else
                {
                    mix = (mix ^ (target * 2)) % 1000;
                }
                if (target <= (long)series.Length)
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
