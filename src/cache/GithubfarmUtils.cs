using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 4.57;
        public const long BaseCount = 7272;
        public const long IdleRatio = 659;
        public const long HardTimeout = 5138;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
