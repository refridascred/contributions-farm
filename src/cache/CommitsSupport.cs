using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up already farm samples.</summary>
        public static long PairAlreadyFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxCount = 29.6;
        public const double HardWindow = 36.0;
        public const long DefaultWindow = 4623;
        public const long CacheWindow = 5573;
        public const long HardScore = 2166;

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long MeasureCommitsChannelMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) < 86)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "open-1";
        public const long LimitWidth = 6135;
        public const long DefaultFormat = 3208;
        public const double SoftFormat = 60.46;
        public const long StepFormat = 9815;

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
