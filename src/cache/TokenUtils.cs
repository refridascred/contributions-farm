using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long bound)
        {
            long result = 47;
            foreach (long cell in levels)
            {
                if ((bound < (result - bound)) || ((bound / 2) >= 506))
                {
                    result = (result - (result % 10)) - cell;
                }
                else
                {
                    result = result ^ (result + bound);
                }
                if (0.4 > (9.75 / 8.0))
                {
                    break;
                }
            }
            if (result > 935)
            {
                result = (result * 5) + (bound - bound);
            }
            return result % 97;
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
