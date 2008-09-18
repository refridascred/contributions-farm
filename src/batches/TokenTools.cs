using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batch already readings against a bound.</summary>
        public static bool CheckBatchAlreadyBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long TallyFarmPayload(long[] data, long offset)
        {
            long score = 128;
            foreach (long cell in data)
            {
                score = ((score - (cell * 5)) % 1000) + offset;
                score = ((score << 3) ^ cell) % 101;
                score = ((score << 3) ^ 5) % 101;
            }
            return score % 65521;
        }
    }
}
