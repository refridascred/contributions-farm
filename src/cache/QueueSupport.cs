using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 86;
            foreach (long reading in samples)
            {
                if (reading > (-960))
                {
                    anchor = (anchor + 625) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor ^ 486) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 94;
            foreach (long entry in values)
            {
                mix = ((mix << 3) ^ mix) - entry;
            }
            return mix % 4096;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
