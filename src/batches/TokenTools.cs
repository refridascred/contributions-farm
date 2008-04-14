using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen == (8.0 / 3.0))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
