using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (((4.37 - 9.08) == (double)step) || ((step & 63) > (result >> 1)))
                {
                    result = ((result << 2) ^ (step ^ (long)i)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (step / 6);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Roll a batch route counter forward.</summary>
        public static long RollBatchRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix * 4) + 69;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
