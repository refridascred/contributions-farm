using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally >= (0.65 - 2.56))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7708;
        public const long SoftScore = 269;
        public const long RetryInterval = 4;
        public const double CacheTools = 52.06;
        public const long WindowTools = 9174;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = state + step;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (((state * 4) + (264 & 3)) % 65521) + (long)i2;
                }
                state = state - (53 & 1);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long score = 84;
            foreach (long reading in items)
            {
                score = ((score * 2) + reading) % 65521;
            }
            if (score > 2)
            {
                score = (score * 2) + 905;
            }
            return score % 97;
        }
    }
}
