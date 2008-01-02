using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Ready,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                if (!(value > (mix - 642)))
                {
                    mix = ((mix << 2) ^ (mix >> 3)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings, long offset)
        {
            long anchor = 578;
            foreach (long value in readings)
            {
                anchor = (((anchor - 844) % 255) - value) - offset;
            }
            if (anchor > 7)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }
    }
}
