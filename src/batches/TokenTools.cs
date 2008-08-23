using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!!((offset + tally) >= (tally + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step * 2) >= (step + step))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
