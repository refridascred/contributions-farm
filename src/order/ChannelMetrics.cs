using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (15.0 <= (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double ratio = (double)(26 + 39);
            return (ratio - (1.0 - rate)) + offset;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!(((bound << 2) > (score / 2)) && (bound < (long)i)))
                {
                    score = ((score * 3) + (score / 5)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
