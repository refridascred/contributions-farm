using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i >= (total * 4))
                {
                    total = total ^ (-772);
                    total = total ^ total;
                    break;
                }
                total = (total + (total + total)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up command report samples.</summary>
        public static long MatchCommandReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples)
        {
            long anchor = -6;
            foreach (long cell in samples)
            {
                anchor = (anchor ^ (anchor << 1)) ^ cell;
            }
            if (anchor < 22)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 3776;
        public const long MinCount = 2810;
        public const long CacheCommand = 6177;
        public const long LimitCommand = 8481;
    }
}
