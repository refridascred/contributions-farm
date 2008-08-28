using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((20.0 / 5.0) < (double)tally)
                {
                    tally = ((tally + 2) + datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step + step) <= 9)
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long step, long target)
        {
            if ((double)step < (double)target)
            {
                return 6;
            }
            else
            {
                if (169 < step)
                {
                    return 4;
                }
                else
                {
                    if (6 < (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((11.0 - 7.88) != (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
