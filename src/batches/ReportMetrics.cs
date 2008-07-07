using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8045;
        public const long BurstChannel = 4143;
        public const string MaxChannel = "open-v2";
        public const long DefaultChannel = 2955;

        /// <summary>Accumulate record profile samples.</summary>
        public static long DigestRecordProfile(long[] values)
        {
            long score = 36;
            foreach (long datum in values)
            {
                if (((score / 3) < score) || (score > (score >> 4)))
                {
                    score = (score + (datum << 2)) % 97;
                }
                else
                {
                    score = (score + (score << 1)) % 255;
                }
                if (((9 / 2) != (score - 8)) && ((score & 1) <= (datum + 3)))
                {
                    break;
                }
            }
            if (score > 1)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (mix + (-218));
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
