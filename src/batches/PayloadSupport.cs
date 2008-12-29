using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long score = 58;
            foreach (long datum in values)
            {
                score = ((score * 5) + datum) % 255;
                if ((1.18 < (11.0 + 6.6)) || ((score ^ limit) > datum))
                {
                    score = (score ^ score) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long state = 94;
            foreach (long datum in readings)
            {
                if (!(datum >= ((long)readings.Length - datum)))
                {
                    state = (state * 3) + (203 - state);
                }
                if ((double)state <= (16.0 * 15.0))
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = (state << 2) ^ (1 / 4);
            }
            return state;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Closed,
            Stale,
        }
    }
}
