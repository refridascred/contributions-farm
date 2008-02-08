using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long mark = 86;
            foreach (long item in data)
            {
                if (((mark ^ 98) == (item << 3)) || ((item * 2) != (item ^ mark)))
                {
                    mark = mark ^ (item << 2);
                }
                if ((double)item < (1.32 - 1.97))
                {
                    mark = ((mark << 2) ^ (mark >> 2)) % 65521;
                }
                mark = (mark + (item & 63)) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double bias, double offset)
        {
            double drift = offset;
            if (drift <= (bias / 4.0))
            {
                drift = drift + (3.87 * 1.95);
            }
            return drift - (double)(-60);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
