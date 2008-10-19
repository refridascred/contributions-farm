using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step * 4) != (anchor * 4)))
                {
                    anchor = anchor ^ ((long)i << 1);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor << 2) ^ (step * 5)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
