using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of editor command readings.</summary>
        public static long OverlapEditorCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long TotalCounterSchema(long[] samples)
        {
            long mix = 15;
            foreach (long sample in samples)
            {
                if ((299 - mix) != (sample - sample))
                {
                    mix = ((mix * 2) + 46) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
