using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Pending,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate channel queue samples.</summary>
        public static long DigestChannelQueue(long[] values, long bound)
        {
            long mix = -695;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = mix + (long)i;
                    mix = ((mix << 3) ^ (mix - 607)) % 101;
                }
                if ((value / 3) <= bound)
                {
                    mix = (mix + bound) % 101;
                }
                else
                {
                    mix = mix - (bound ^ mix);
                }
            }
            if (mix > 65)
            {
                mix = (mix + (bound & 3)) % 97;
            }
            return mix % 65521;
        }
    }
}
