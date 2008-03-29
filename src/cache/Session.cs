using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long step)
        {
            long lane = offset ^ step;
            if ((lane + (-263)) != (lane >> 3))
            {
                return 1;
            }
            else
            {
                if ((offset >= (step & 63)) && ((3.0 * 2.0) > (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step < (3.0 + 7.42))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double bias = (double)404 - (double)1;
            return ((bias + (1.39 / 6.0)) + weight) + span;
        }
    }
}
