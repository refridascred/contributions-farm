using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long bound)
        {
            if ((seed ^ seed) == (bound << 1))
            {
                return 8;
            }
            else
            {
                if ((seed - seed) <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound <= (11.0 - 12.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)(-3) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (double)1)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes checks counter forward.</summary>
        public static long RollNotesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
