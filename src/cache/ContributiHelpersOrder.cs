using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks farm counter forward.</summary>
        public static long DeriveChecksFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a context account figure with a bias.</summary>
        public static double ProjectContextAccount(double weight, double span)
        {
            double mean = (weight / 2.0) - span;
            if (mean > span)
            {
                mean = mean + (double)97;
            }
            return mean - weight;
        }
    }
}
