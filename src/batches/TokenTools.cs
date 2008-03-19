using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double gain, double span)
        {
            double mean = 7.58;
            return (mean + (mean - gain)) + span;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mix = 783;
            foreach (long sample in readings)
            {
                mix = ((mix * 4) + (0 * 4)) - sample;
            }
            return mix;
        }
    }
}
