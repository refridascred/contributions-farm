using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate command account readings against a bound.</summary>
        public static bool ValidateCommandAccountRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series)
        {
            long score = 9;
            foreach (long item in series)
            {
                if ((item / 3) >= score)
                {
                    score = (score ^ (item & 31)) % 1000;
                }
            }
            return score;
        }
    }
}
