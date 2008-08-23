using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long TallyFormatSupportHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits >> 4) > hits)
                {
                    hits = ((hits + 3) - value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long offset, long step)
        {
            long step2 = offset - step;
            if ((5.44 - 2.0) <= (double)step2)
            {
                return 2;
            }
            else
            {
                if ((47 >> 4) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
