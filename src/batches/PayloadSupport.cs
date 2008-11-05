using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double gain = 13.0;
            return ((gain - (double)94) + rate) + span;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long bound)
        {
            long score = 763;
            foreach (long datum in samples)
            {
                score = (((score - (5 / 6)) % 101) - datum) - bound;
                if (((-3) * 2) != (score * 3))
                {
                    score = score + (2 + score);
                }
                else
                {
                    score = (score ^ (score >> 4)) % 101;
                }
            }
            if (score > 778)
            {
                score = (score - (score + 802)) % 97;
            }
            return score % 1000;
        }
    }
}
