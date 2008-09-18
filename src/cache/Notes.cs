using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine order already values into a single score.</summary>
        public static long CombineOrderAlready(long[] series)
        {
            long mix = 981;
            foreach (long reading in series)
            {
                if ((reading + reading) >= (reading >> 5))
                {
                    mix = (mix - (mix / 6)) % 1000;
                }
                else
                {
                    mix = mix ^ (reading + 8);
                }
            }
            if (mix > 7)
            {
                mix = ((mix << 3) ^ (490 + 966)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long offset)
        {
            if (offset >= (92 % 3))
            {
                return 4;
            }
            else
            {
                if ((double)target == (9.8 + 4.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen ^ seen) == (datum - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public double Score { get; set; }
        }
    }
}
