using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many layout record samples are out of range.</summary>
        public static long TallyLayoutRecordMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (18.0 <= (3.21 - 6.2))
                {
                    matches = ((matches + 1) + entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((((6 / 8) > matches) || ((datum & 63) != (datum % 5))) && (((double)datum <= 6.93) && ((double)datum <= (double)matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long limit)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = (mix - (limit + sample)) % 97;
            }
            return mix;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9763;
        public const double HardBuffer = 5.31;
        public const double MaxBuffer = 79.28;
        public const long LimitBuffer = 8880;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 9149;
        public const long MaxQueue = 6775;
        public const long WindowScore = 800;
        public const long BaseBudget = 2148;
        public const double BaseQueue = 6.72;
    }
}
