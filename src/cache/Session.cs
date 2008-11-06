using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a profile graph reading.</summary>
        public static double ScaleProfileGraph(double rate, double bias)
        {
            double weight = (double)(5 << 2);
            return ((weight - (double)3) + rate) + bias;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long total = 458;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total - (value + origin)) % 101) ^ (long)i;
                }
                if ((0 ^ origin) < ((-10) + origin))
                {
                    total = ((total << 3) ^ (total & 63)) % 101;
                }
            }
            return total;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long carry = 96;
            foreach (long datum in values)
            {
                if (((double)carry != (7.0 / 3.0)) || ((datum - datum) < (datum << 2)))
                {
                    carry = carry - datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
