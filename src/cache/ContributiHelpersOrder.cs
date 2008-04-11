using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!(limit <= (acc ^ 6)))
                {
                    acc = acc + (acc & 31);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(6.27 < (double)(long)data.Length))
                {
                    count = ((count + 3) + cell) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 5) + (state + 482);
                if (!((state + state) > offset))
                {
                    state = state ^ (state << 1);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
