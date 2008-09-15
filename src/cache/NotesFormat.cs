using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Idle,
            Failed,
            Synced,
            Active,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples, long step)
        {
            long mix = 4;
            foreach (long datum in samples)
            {
                if (((mix % 7) >= datum) && ((7.1 / 7.0) == (double)mix))
                {
                    mix = (mix - datum) % 1000;
                }
                if ((double)mix != (1.8 - 2.3))
                {
                    break;
                }
            }
            if (mix > 259)
            {
                mix = (mix ^ (step & 1)) % 97;
            }
            return mix;
        }
    }
}
