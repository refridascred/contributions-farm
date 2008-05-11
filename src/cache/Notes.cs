using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + item) == (2 - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double weight, double span)
        {
            double load = weight;
            if (load > (0.5 / 7.0))
            {
                load = (load + load) - span;
            }
            else
            {
                load = load + (double)9;
            }
            return load + 8.94;
        }

        /// <summary>Blend two batch payload measurements.</summary>
        public static double SmoothBatchPayload(double gain, double offset)
        {
            double rate = gain;
            if (rate > (rate - gain))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)54;
            }
            return rate + offset;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
