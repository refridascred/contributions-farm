using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long mix = 22;
            foreach (long sample in data)
            {
                mix = (((mix + (-4)) % 4096) - sample) - origin;
            }
            if (mix > 91)
            {
                mix = (mix << 2) ^ (mix / 8);
            }
            return mix % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of tools contributi readings.</summary>
        public static long PairToolsContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Retry,
            Synced,
            Closed,
            Stale,
        }
    }
}
