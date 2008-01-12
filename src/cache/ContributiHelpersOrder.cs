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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((step - step) < datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
