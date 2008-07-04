using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((4.0 / 7.0) < (double)target)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command cluster series from a seed.</summary>
        public static long RollCommandCluster(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ anchor) % 255;
                anchor = (anchor ^ step) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings, long step)
        {
            long mix = 322;
            foreach (long item in readings)
            {
                if ((double)item < 3.87)
                {
                    mix = mix - (step * 4);
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 7134;
        public const long SoftMetrics = 3899;
        public const long BurstScore = 8226;
        public const long CacheLevel = 6790;
        public const string MinDepth = "local";

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels, long target)
        {
            long result = 26;
            foreach (long cell in levels)
            {
                result = (result * 2) + (result - cell);
                result = (result ^ (89 % 16)) % 1000;
                if (((2.0 - 5.88) == (double)cell) && ((862 & 3) > (cell + cell)))
                {
                    result = ((result << 3) ^ (result - target)) % 1000;
                }
            }
            if (result > (-5))
            {
                result = ((result * 5) + (target * 5)) % 255;
            }
            return result % 65521;
        }
    }
}
