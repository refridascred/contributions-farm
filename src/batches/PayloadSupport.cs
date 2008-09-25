using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long datum in samples)
            {
                mix = ((mix ^ (mix - mix)) + datum) + offset;
            }
            if (mix < 46)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Find the first graph support entry that matches the target.</summary>
        public static long LookupGraphSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
