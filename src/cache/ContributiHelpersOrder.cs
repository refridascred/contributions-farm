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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value > (target >> 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
