using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a cluster graph reading.</summary>
        public static double AdjustClusterGraph(double ratio, double floor)
        {
            double mean = (double)(4 + 83);
            return (mean - ratio) + floor;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels)
        {
            long result = 993;
            foreach (long value in levels)
            {
                if ((value * 3) <= (result * 4))
                {
                    result = (result * 2) + result;
                }
                if ((result << 1) != (value * 5))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
