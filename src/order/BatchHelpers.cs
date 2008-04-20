using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean + (mean + span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
