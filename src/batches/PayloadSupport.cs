using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen ^ step) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long TallyNotesTools(long[] items)
        {
            long score = 55;
            foreach (long sample in items)
            {
                if (936 >= (49 + sample))
                {
                    score = score + (sample - sample);
                }
            }
            return score;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            New,
        }
    }
}
