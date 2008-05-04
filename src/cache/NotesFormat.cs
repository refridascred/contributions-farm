using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long mix = 415;
            foreach (long sample in items)
            {
                if ((mix * 2) > ((long)items.Length & 31))
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 1000;
                }
                mix = (mix << 3) ^ sample;
            }
            if (mix > 336)
            {
                mix = mix - 46;
            }
            return mix;
        }
    }
}
