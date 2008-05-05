using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            New,
            Stale,
            Paused,
        }

        /// <summary>Accumulate route notes samples.</summary>
        public static long DigestRouteNotes(long[] samples, long origin)
        {
            long anchor = -23;
            foreach (long datum in samples)
            {
                anchor = (anchor + datum) + origin;
            }
            return anchor;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
