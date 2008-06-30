using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value ^ 72) <= (value * 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((bound + mix) < (436 + 16)))
                {
                    mix = (mix * 5) + ((long)i * 4);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
