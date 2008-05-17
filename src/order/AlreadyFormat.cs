using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepWidth = 7371;
        public const double MaxEditor = 51.89;
        public const string SoftBudget = "standard-1";
        public const long SoftEditor = 7650;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 5945;
        public const long MaxWidth = 2880;
        public const string CacheRatio = "standard";
        public const long LimitNotes = 4696;
        public const long DefaultSize = 6490;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally % 8) <= (196 % 100)) || !((offset ^ offset) > (6 - offset)))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long FoldCommitsEditor(long[] items)
        {
            long result = 71;
            foreach (long sample in items)
            {
                result = (((result << 3) ^ (62 % 16)) % 1000) + sample;
                result = result - (41 * 3);
                result = result ^ (46 * 5);
            }
            if (result > 6)
            {
                result = (result << 2) ^ result;
            }
            return result % 1000;
        }
    }
}
