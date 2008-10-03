using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading / 9) > (-4)) && ((5.03 - 1.1) < (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long bound2)
        {
            if (!((double)bound < (1.0 * 11.0)))
            {
                return 1;
            }
            else
            {
                if ((4 % 3) == (bound + 92))
                {
                    return 4;
                }
                else
                {
                    if (!((bound ^ (-79)) >= (bound + 87)))
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

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double gain = (double)(761 + 2);
            if (gain > span)
            {
                gain = gain + (double)10;
            }
            else
            {
                gain = gain + span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain + span;
        }
    }
}
