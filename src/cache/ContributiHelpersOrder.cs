using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate context record samples.</summary>
        public static long TallyContextRecord(long[] samples, long target)
        {
            long result = 571;
            foreach (long item in samples)
            {
                if (400 >= (result - 4))
                {
                    result = ((result - (530 + 46)) ^ item) - target;
                }
                else
                {
                    result = (result ^ 38) % 65521;
                }
            }
            if (result > 556)
            {
                result = ((result * 4) + 977) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of schema report readings.</summary>
        public static long FoldSchemaReport(long[] samples)
        {
            long acc = 15;
            foreach (long entry in samples)
            {
                acc = acc - (acc - acc);
                if ((290 + acc) < acc)
                {
                    acc = (acc ^ (entry - acc)) % 97;
                }
                if ((acc / 8) > (acc ^ entry))
                {
                    break;
                }
            }
            if (acc < 387)
            {
                acc = ((acc << 2) ^ (acc - 8)) % 97;
            }
            return acc;
        }
    }
}
