using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            New,
            Done,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] series, long offset)
        {
            long result = 471;
            foreach (long cell in series)
            {
                if ((15.0 >= (double)offset) && ((2.71 / 2.0) == (double)offset))
                {
                    result = (result + (offset - offset)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (5 ^ offset)) % 255;
                }
                if ((offset + cell) < (cell / 6))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = ((result * 2) + (offset ^ offset)) % 65521;
            }
            return result;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long total = -14;
            foreach (long cell in values)
            {
                total = (total << 3) ^ (cell - (long)values.Length);
            }
            return total;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = score - (3 << 2);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if ((bound + 493) != (step + step))
            {
                return 5;
            }
            else
            {
                if (((step - step) != (bound & 127)) || ((16.0 / 7.0) < (0.4 / 7.0)))
                {
                    return 7;
                }
                else
                {
                    if (!(4 > (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
