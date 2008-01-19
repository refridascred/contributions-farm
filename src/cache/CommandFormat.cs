using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count account graph pairs that satisfy a relation.</summary>
        public static long MatchAccountGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph cache samples.</summary>
        public static long CombineGraphCache(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                anchor = (anchor << 2) ^ (anchor >> 3);
                if ((entry + entry) < (anchor / 4))
                {
                    anchor = (anchor - (28 % 12)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (-138)) % 4096;
                }
                if ((double)entry == (7.9 / 5.0))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Pending,
            Closed,
        }
    }
}
