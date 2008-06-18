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

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long CountFarmTokenHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(tally < (tally - tally)))
                {
                    tally = ((tally + 2) + value) - target;
                }
            }
            return tally;
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
