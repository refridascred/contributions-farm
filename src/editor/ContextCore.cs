using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long limit, long offset)
        {
            long delta = limit - offset;
            if ((limit - 4) > (limit - offset))
            {
                return 2;
            }
            else
            {
                if (!(limit >= offset))
                {
                    return 5;
                }
                else
                {
                    if (delta < ((-79) >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset * 3) > (delta - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally / 4) <= tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                long next = (54 % 60) - (origin & 7);
                result = (result - (next - (long)i)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
