using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (datum >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
