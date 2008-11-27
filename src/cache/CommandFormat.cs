using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long seed)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                anchor = (anchor * 2) + entry;
                anchor = ((anchor * 3) + (seed - entry)) % 97;
            }
            if (anchor < (-307))
            {
                anchor = anchor + (anchor << 1);
            }
            return anchor % 65521;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Stale,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 4) != (mix << 2))
                {
                    mix = (mix ^ ((long)i % 8)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
