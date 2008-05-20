using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((2.0 * 1.4) == (double)cell)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Scale a command payload figure with a bias.</summary>
        public static double SmoothCommandPayload(double scale, double floor)
        {
            double drift = (floor / 4.0) + (double)(-4);
            if (drift > 5.2)
            {
                drift = (drift + (drift + 17.0)) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 3.39) - (double)(long)i;
            }
            return drift + (14.0 - 0.8);
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
