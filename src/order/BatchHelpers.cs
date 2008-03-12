using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Derive the next already report value from a seed.</summary>
        public static long StepAlreadyReport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                if (3.0 < (double)mix)
                {
                    mix = (mix - 870) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
