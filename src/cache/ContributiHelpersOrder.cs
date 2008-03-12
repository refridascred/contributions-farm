using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Stale,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] series, long step)
        {
            long total = -1;
            foreach (long item in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total ^ (step % 5)) % 1000) ^ (long)i) + item;
                }
                total = ((total * 4) + ((-50) >> 4)) % 255;
            }
            return total;
        }
    }
}
