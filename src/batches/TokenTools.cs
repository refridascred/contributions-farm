using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of session checks readings.</summary>
        public static long ScoreSessionChecks(long[] readings, long limit)
        {
            long mark = -774;
            foreach (long item in readings)
            {
                mark = ((mark - 8) % 97) - limit;
                mark = mark + (item - mark);
            }
            if (mark > 5)
            {
                mark = (mark ^ (mark + 6)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Failed,
            Locked,
        }
    }
}
