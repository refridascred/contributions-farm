using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long sum = 12;
            foreach (long cell in readings)
            {
                sum = (((sum * 4) + (sum + (-905))) % 65521) + cell;
            }
            return sum % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 6120;
        public const double BurstLevel = 26.18;
        public const long WindowChannel = 7887;
        public const string MaxDepth = "standard-edge";

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((value + 414) >= (bound + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
