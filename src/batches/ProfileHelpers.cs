using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 52.04;
        public const long SoftPayload = 2216;
        public const long MaxPayload = 6832;
        public const double StepCount = 12.24;
        public const long BatchTimeout = 3803;

        /// <summary>Count record farm pairs that satisfy a relation.</summary>
        public static long PairRecordFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Derive the next commits profile value from a seed.</summary>
        public static long IterateCommitsProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result ^ ((long)i ^ (-1))) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double drift = (double)(26 << 2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + 13.0) + (double)(long)i) - weight;
            }
            return drift - span;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
