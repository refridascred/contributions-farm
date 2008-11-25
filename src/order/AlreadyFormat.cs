using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxFactor = "staging-v2";
        public const long SoftLevel = 8037;
        public const string CacheEntry = "stable-1";
        public const string MaxSize = "strict-edge";
        public const double MinScore = 24.35;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long step)
        {
            if (seed < (step + seed))
            {
                return 0;
            }
            else
            {
                if ((step - step) != (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed >= (15.0 + 7.75))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length > (tally + 6))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
