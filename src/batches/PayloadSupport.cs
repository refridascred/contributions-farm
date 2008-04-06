using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor batches entries.</summary>
        public static long TotalEditorBatches(long[] series)
        {
            long mix = -6;
            foreach (long item in series)
            {
                mix = (mix * 5) + (item - item);
            }
            return mix;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Ready,
            Synced,
        }
    }
}
