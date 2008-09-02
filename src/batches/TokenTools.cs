using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double ratio = (gain + span) * 6.5;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (gain + gain)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4 + limit) < (755 / 7))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
