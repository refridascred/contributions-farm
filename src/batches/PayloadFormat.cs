using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length >= (tally + tally))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next buffer stream value.</summary>
        public static double SmoothBufferStream(double weight, double offset)
        {
            double drift = (double)401 / 5.0;
            if (drift <= (double)338)
            {
                drift = (drift + (offset / 3.0)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
