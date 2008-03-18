using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels, long offset)
        {
            long anchor = 221;
            foreach (long entry in levels)
            {
                anchor = (anchor + 89) % 97;
                if ((3.53 - 5.98) > (double)entry)
                {
                    anchor = anchor ^ (offset >> 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((acc ^ step) >= (acc + step)))
                {
                    acc = (acc - (acc >> 5)) % 97;
                }
                acc = ((acc << 3) ^ (acc << 2)) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two buffer notes measurements.</summary>
        public static double SmoothBufferNotes(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= rate)
            {
                ratio = (ratio - 4.4) - span;
            }
            return ratio + ratio;
        }
    }
}
