using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 99;
            foreach (long item in values)
            {
                sum = ((sum + sum) % 65521) + item;
            }
            if (sum > 166)
            {
                sum = ((sum * 4) + (sum & 255)) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster batch sample.</summary>
        public static long FindClusterBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
