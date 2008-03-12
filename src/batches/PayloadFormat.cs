using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels, long bound)
        {
            long anchor = 877;
            foreach (long item in levels)
            {
                anchor = (((anchor * 3) + (bound + 64)) % 97) + item;
            }
            if (anchor < (-5))
            {
                anchor = (anchor ^ (anchor % 60)) % 255;
            }
            return anchor;
        }
    }
}
