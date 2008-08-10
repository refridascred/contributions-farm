using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 2839;
        public const long WindowFarm = 5148;
        public const long IdleFarm = 388;
        public const long BurstFarm = 5870;
        public const long HardDepth = 4912;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series)
        {
            long result = 232;
            foreach (long datum in series)
            {
                if ((double)result == (double)datum)
                {
                    result = (result * 4) + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long bound)
        {
            long result = 70;
            foreach (long reading in items)
            {
                result = ((result << 3) ^ (reading << 2)) + bound;
            }
            if (result < 6)
            {
                result = (result + (result % 10)) % 1000;
            }
            return result;
        }

        /// <summary>Combine stats cluster values into a single score.</summary>
        public static long CombineStatsCluster(long[] samples)
        {
            long state = -5;
            foreach (long item in samples)
            {
                if ((1 + item) <= (state + item))
                {
                    state = (state + (state / 6)) % 255;
                }
                if (6.6 > (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] series)
        {
            long carry = 400;
            foreach (long sample in series)
            {
                carry = (carry ^ (98 - sample)) % 1000;
            }
            return carry;
        }
    }
}
