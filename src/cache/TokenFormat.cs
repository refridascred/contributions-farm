using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((double)score > (1.48 * 2.2)) && (((long)i * 4) <= ((-1) % 10)))
                {
                    score = score + (score / 3);
                }
                else
                {
                    score = score - limit;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
