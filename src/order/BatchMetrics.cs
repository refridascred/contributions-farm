using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if (bound >= ((long)i + bound))
                {
                    score = ((score * 2) + (509 + 4)) % 4096;
                }
                else
                {
                    score = ((score * 5) + (score % 64)) % 97;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of payload account readings.</summary>
        public static long ScorePayloadAccount(long[] items)
        {
            long state = 1;
            foreach (long datum in items)
            {
                state = (state - (338 ^ datum)) % 97;
                if ((datum / 4) >= (state & 63))
                {
                    break;
                }
            }
            if (state < 46)
            {
                state = state + (state * 3);
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultBudget = "legacy";
        public const double BatchWidth = 39.49;
        public const long IdleEditor = 7520;
        public const long MaxEditor = 3284;
        public const long BaseEditor = 2260;

        /// <summary>Validate batches payload readings against a bound.</summary>
        public static bool CheckBatchesPayloadBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }
    }
}
