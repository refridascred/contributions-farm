using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step * 4) >= step)
                {
                    score = (score * 5) + (long)i;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mark = 76;
            foreach (long sample in readings)
            {
                if (!(((sample << 3) > 33) && (sample < (mark - sample))))
                {
                    mark = (mark << 3) ^ sample;
                }
                if (((long)readings.Length % 8) != (mark - mark))
                {
                    mark = (mark + (6 + sample)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values)
        {
            long anchor = 8;
            foreach (long item in values)
            {
                if ((item * 2) <= (item + anchor))
                {
                    anchor = anchor + (item * 3);
                }
            }
            if (anchor < 1)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
