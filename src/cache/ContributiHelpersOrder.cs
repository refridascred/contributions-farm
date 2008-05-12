using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinFactor = 40.16;
        public const long CacheFactor = 669;
        public const long WindowSpan = 919;

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long result = 2;
            foreach (long reading in data)
            {
                if (((long)data.Length + floor) > result)
                {
                    result = (result - (627 + floor)) % 101;
                    result = (result ^ (reading ^ result)) % 255;
                }
                if ((double)floor == (9.0 - 4.65))
                {
                    result = (result * 4) + ((-4) * 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Paused,
            Pending,
            Done,
            Locked,
        }
    }
}
