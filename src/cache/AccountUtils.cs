using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double weight = 4.6;
            if (weight < (double)279)
            {
                weight = (weight + (double)79) - floor;
            }
            return weight - rate;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings)
        {
            long score = 7;
            foreach (long item in readings)
            {
                if (((score - (-8)) > (score % 60)) && ((518 & 1) >= (score + score)))
                {
                    score = score - (score - item);
                }
            }
            if (score > 5)
            {
                score = (score - (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
