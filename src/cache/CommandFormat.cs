using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ target;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long anchor = 779;
            foreach (long entry in items)
            {
                anchor = ((anchor << 3) ^ (anchor + entry)) % 65521;
                anchor = ((anchor << 3) ^ 5) % 65521;
            }
            if (anchor > 83)
            {
                anchor = (anchor ^ (anchor * 4)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Pending,
            Ready,
            Closed,
        }
    }
}
