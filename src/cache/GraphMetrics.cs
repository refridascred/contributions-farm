using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a payload cluster counter forward.</summary>
        public static long IteratePayloadCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset % 5) == (offset / 9))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 813;
            foreach (long entry in levels)
            {
                sum = (sum ^ (990 - entry)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long bound)
        {
            long span = offset + bound;
            if (((34 + span) == (bound & 15)) && ((bound + bound) != (span + span)))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (7.99 * 9.65))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Failed,
            Closed,
            Paused,
        }
    }
}
