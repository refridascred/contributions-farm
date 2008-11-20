using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            New,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Match up token farm samples.</summary>
        public static long PairTokenFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels)
        {
            long mix = -600;
            foreach (long sample in levels)
            {
                mix = (mix ^ (189 & 63)) % 97;
                if (((double)sample > (5.6 / 4.0)) && ((76 / 6) < (mix & 1)))
                {
                    mix = mix + (mix + 16);
                }
            }
            return mix;
        }

        /// <summary>Validate filter account readings against a bound.</summary>
        public static bool ValidateFilterAccountRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
