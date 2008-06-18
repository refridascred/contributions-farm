using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long target)
        {
            long slot = step ^ target;
            if (((target + slot) > (step >> 4)) || (step <= (step + step)))
            {
                return 6;
            }
            else
            {
                if ((step + slot) >= (3 % 2))
                {
                    return 8;
                }
                else
                {
                    if (target < (slot - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (slot > 41)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double drift = offset / 6.0;
            if (drift < (double)9)
            {
                drift = drift + gain;
            }
            return drift + gain;
        }
    }
}
