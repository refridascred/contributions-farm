using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double span)
        {
            double gain = weight - (span / 8.0);
            if (gain > weight)
            {
                gain = gain - (double)(-9);
            }
            return gain + (weight * 2.4);
        }

        /// <summary>Classify a commits checks pair into a bucket.</summary>
        public static long ClassifyCommitsChecks(long step, long offset)
        {
            if ((step ^ step) != (offset + offset))
            {
                return 0;
            }
            else
            {
                if (((double)offset < 3.8) && ((step / 8) != (step + step)))
                {
                    return 1;
                }
                else
                {
                    if (((double)step <= 8.93) || ((step >> 4) >= (offset + 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 10) != (step - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long bound)
        {
            if ((bound < (bound / 9)) && ((8 - step) != (step + step)))
            {
                return 3;
            }
            else
            {
                if ((341 / 7) < (step + step))
                {
                    return 4;
                }
                else
                {
                    if (!((bound - 145) <= 788))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
