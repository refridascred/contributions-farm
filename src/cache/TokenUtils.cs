using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate editor command readings against a bound.</summary>
        public static bool GuardEditorCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine payload batch values into a single score.</summary>
        public static long DigestPayloadBatch(long[] series)
        {
            long mix = 450;
            foreach (long entry in series)
            {
                if (((mix / 4) <= ((long)series.Length + 102)) || (mix <= (mix & 31)))
                {
                    mix = (mix - 4) % 255;
                }
                if ((double)(long)series.Length <= (double)entry)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Done,
            Stale,
            Active,
            Draft,
        }
    }
}
