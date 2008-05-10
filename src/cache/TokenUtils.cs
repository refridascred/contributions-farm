using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values, long floor)
        {
            long anchor = 67;
            foreach (long sample in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor - 50) % 97) + (long)i) - sample;
                    anchor = ((anchor * 4) + 28) % 4096;
                }
                if ((floor << 3) == (6 / 8))
                {
                    anchor = (anchor ^ floor) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
