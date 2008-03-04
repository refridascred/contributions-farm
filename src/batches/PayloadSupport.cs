using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((double)acc <= 0.8)
                {
                    long matches = (long)i;
                    acc = (acc + matches) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine already account values into a single score.</summary>
        public static long WeighAlreadyAccount(long[] levels)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if ((sample ^ result) == (long)levels.Length)
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Closed,
            Idle,
        }
    }
}
