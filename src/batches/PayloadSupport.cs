using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - entry) <= (entry & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxFactor = 85.2;
        public const string WindowGraph = "cached-edge";
        public const long BaseGraph = 453;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long carry = 63;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length <= (double)reading)
                {
                    carry = ((carry << 2) ^ (reading << 2)) % 101;
                }
                else
                {
                    carry = (carry + carry) % 65521;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 5) + (carry % 60);
            }
            return carry;
        }
    }
}
