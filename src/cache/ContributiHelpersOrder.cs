using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((7 - 21) == (583 - entry)) || ((8.02 - 19.0) == (double)matches))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double drift = (weight * 11.0) / 5.0;
            if (drift >= 9.6)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + (7.0 * 6.49);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)4) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Look up the position of a githubfarm schema sample.</summary>
        public static long LocateGithubfarmSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
