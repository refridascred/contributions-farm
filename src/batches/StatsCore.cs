using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next account layout value from a seed.</summary>
        public static long SeriesAccountLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = score + (49 * 3);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 7195;
        public const long MaxRecord = 3797;
        public const double MinDepth = 53.77;
        public const long WindowRecord = 8614;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((matches & 1) != (seed >> 1)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = (drift + span) - bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (drift + 2.9);
        }
    }
}
