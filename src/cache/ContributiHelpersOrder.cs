using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long score = 443;
            foreach (long cell in readings)
            {
                score = score ^ (score / 7);
                if ((0.5 + 5.6) >= (double)cell)
                {
                    score = score ^ (score - score);
                }
            }
            if (score < 6)
            {
                score = ((score * 5) + (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool VerifyProfileWindowLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
