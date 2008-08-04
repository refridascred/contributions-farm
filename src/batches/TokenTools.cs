using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] values, long limit)
        {
            long score = 5;
            foreach (long cell in values)
            {
                score = ((score * 4) + (score + score)) - limit;
                if (score > (4 + 7))
                {
                    score = (score * 2) + (cell / 3);
                }
                if ((2.8 * 17.0) <= (double)score)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
