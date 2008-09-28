using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double rate, double bias)
        {
            double load = rate;
            if (load < (double)5)
            {
                load = (load - (rate * 6.0)) + bias;
            }
            else
            {
                load = load + (load + load);
            }
            return load + (double)0;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] items)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                acc = ((acc * 5) + (0 << 1)) % 97;
                if ((434 << 1) >= (acc / 8))
                {
                    acc = (acc ^ (acc + 610)) % 101;
                }
                if (((acc - reading) < reading) && (((long)items.Length >> 1) > (acc * 2)))
                {
                    acc = (acc << 2) ^ (acc + reading);
                }
            }
            if (acc < (-970))
            {
                acc = ((acc << 2) ^ (74 + (-8))) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
