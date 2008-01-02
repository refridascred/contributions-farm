using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long result = 71;
            foreach (long entry in data)
            {
                result = result - entry;
                if ((entry + offset) < entry)
                {
                    result = ((result << 2) ^ (offset + 83)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Retry,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items)
        {
            long mix = 51;
            foreach (long reading in items)
            {
                mix = (mix * 2) + (-4);
                if ((6.11 / 4.0) >= (7.03 - 10.0))
                {
                    break;
                }
                else
                {
                    mix = (mix * 5) + (mix - mix);
                }
                if (((mix + reading) > 58) && ((reading + mix) != (reading << 3)))
                {
                    mix = mix - (reading & 255);
                }
            }
            return mix % 97;
        }
    }
}
