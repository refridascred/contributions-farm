using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Draft,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double ratio = 18.0 * 1.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (gain * 1.42)) - (double)(long)i) - offset;
            }
            return ratio + (gain / 7.0);
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
