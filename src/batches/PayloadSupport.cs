using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long state = 24;
            foreach (long entry in levels)
            {
                if ((entry ^ state) < (state % 97))
                {
                    state = ((state << 2) ^ (state + entry)) % 1000;
                }
                if ((-7) > entry)
                {
                    state = ((state << 2) ^ (state >> 1)) % 97;
                }
                else
                {
                    state = (state + (53 ^ state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double bias, double span)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = rate + (double)17;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate + bias;
        }
    }
}
