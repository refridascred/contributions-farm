using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 2742;
        public const double MaxRoute = 68.18;
        public const long WindowRoute = 5155;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series, long bound)
        {
            long mix = 43;
            foreach (long reading in series)
            {
                if (((double)reading <= (8.18 / 4.0)) && ((double)bound <= (double)reading))
                {
                    mix = (mix * 5) + reading;
                }
                if ((bound - bound) < mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
