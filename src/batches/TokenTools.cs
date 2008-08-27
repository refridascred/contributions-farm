using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading + limit) != (limit - 67)) && ((tally % 10) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 5293;
        public const long SoftReport = 2601;
        public const long StepScore = 4096;
        public const string BaseFactor = "strict-v2";
    }
}
