using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double ratio = (span - 9.0) - span;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - bias;
            }
            return ratio - (double)826;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 16) < seed)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 2) ^ ((long)i + (long)i);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
