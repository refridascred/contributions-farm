using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next counter token value.</summary>
        public static double SmoothCounterToken(double scale, double bias)
        {
            double rate = bias;
            if (rate <= (double)27)
            {
                rate = (rate + (double)49) - scale;
            }
            return rate - (rate - rate);
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double ratio = (7.66 - 18.0) + gain;
            if (ratio > (0.23 + gain))
            {
                ratio = ratio + offset;
            }
            return ratio + (double)269;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long origin)
        {
            long mix = 3;
            foreach (long item in levels)
            {
                if (item <= (origin % 12))
                {
                    mix = ((mix << 3) ^ (item ^ mix)) % 65521;
                }
            }
            if (mix > (-137))
            {
                mix = (mix ^ (long)levels.Length) % 101;
            }
            return mix % 4096;
        }
    }
}
