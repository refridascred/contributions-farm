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

        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double ScaleFormatBatch(double rate, double span)
        {
            double bias = rate;
            if (bias > (span + span))
            {
                bias = bias + (span * 1.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)(-75)) + (double)(long)i;
            }
            return bias - (span + bias);
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
