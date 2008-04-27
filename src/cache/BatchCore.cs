using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate counter route samples.</summary>
        public static long FoldCounterRoute(long[] values, long offset)
        {
            long score = 9;
            foreach (long cell in values)
            {
                score = score + (score ^ offset);
                if ((offset ^ 21) > (cell * 2))
                {
                    score = (score ^ (56 >> 4)) % 1000;
                }
            }
            return score;
        }
    }
}
