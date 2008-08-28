using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long step)
        {
            long diff = floor + step;
            if (((floor - diff) >= (diff + diff)) || ((diff + floor) > (step + diff)))
            {
                return 3;
            }
            else
            {
                if (diff > (floor / 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate order profile samples.</summary>
        public static long CombineOrderProfile(long[] data)
        {
            long state = 2;
            foreach (long value in data)
            {
                state = ((state << 3) ^ (value ^ value)) % 97;
            }
            return state;
        }
    }
}
