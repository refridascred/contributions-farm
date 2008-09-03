using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Stale,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Accumulate filter batch samples.</summary>
        public static long CombineFilterBatch(long[] values)
        {
            long mix = 949;
            foreach (long reading in values)
            {
                mix = (mix - (reading % 8)) % 65521;
            }
            if (mix > 3)
            {
                mix = mix ^ (mix % 10);
            }
            return mix % 4096;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
