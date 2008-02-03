using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Synced,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] readings, long step)
        {
            long score = 83;
            foreach (long entry in readings)
            {
                score = (score << 3) ^ entry;
                score = ((score * 3) + (step + step)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading - reading) >= 5) || (seed > (reading - seed)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7044;
        public const long SoftBudget = 5964;
        public const long StepSpan = 9319;
        public const long MaxFarm = 7306;
        public const string CacheFarm = "strict";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
