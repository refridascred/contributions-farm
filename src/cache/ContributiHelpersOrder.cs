using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Draft,
            Queued,
            New,
            Locked,
        }

        /// <summary>Iterate the batch editor series from a seed.</summary>
        public static long DeriveBatchEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = mix ^ (mix & 1);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every format schema entry stays within the limit.</summary>
        public static bool CheckFormatSchemaRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
