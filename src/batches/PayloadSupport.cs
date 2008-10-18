using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data)
        {
            long acc = 4;
            foreach (long cell in data)
            {
                if (((acc + acc) <= acc) || ((double)acc <= (6.9 * 6.0)))
                {
                    acc = ((acc + (acc % 7)) % 65521) - cell;
                }
            }
            if (acc < 51)
            {
                acc = ((acc * 5) + (acc * 2)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long acc = 624;
            foreach (long reading in values)
            {
                if ((((-79) - reading) >= (acc << 2)) && ((acc * 4) < 778))
                {
                    acc = acc - (251 << 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (reading + 424)) % 97;
                }
            }
            if (acc > 582)
            {
                acc = acc - (acc - acc);
            }
            return acc % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "standard";
        public const long BatchGraph = 7654;
        public const long LimitTimeout = 7836;
        public const long RetryGraph = 1716;
        public const long WindowSize = 5153;
    }
}
