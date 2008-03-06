using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double gain, double offset)
        {
            double mean = 4.5;
            if (mean >= (gain - 4.0))
            {
                mean = (mean + mean) - offset;
            }
            return mean + (double)478;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long seed2)
        {
            long step = seed + seed2;
            if ((seed / 6) <= seed)
            {
                return 0;
            }
            else
            {
                if (seed < step)
                {
                    return 5;
                }
                else
                {
                    if ((step / 7) > (seed2 & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up support route samples.</summary>
        public static long CompareSupportRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
