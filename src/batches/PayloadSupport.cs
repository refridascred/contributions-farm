using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long TallyGraphSchemaGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 3) == (tally % 10))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + 6) > (bound / 8))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double span)
        {
            double rate = (span / 5.0) + span;
            if (rate > (double)4)
            {
                rate = rate + 13.0;
            }
            else
            {
                rate = rate + (16.0 / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
