using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix + (mix & 127)) % 65521;
                mix = (mix + (floor & 1)) % 65521;
                mix = (mix - (floor / 5)) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            New,
            Failed,
        }
    }
}
