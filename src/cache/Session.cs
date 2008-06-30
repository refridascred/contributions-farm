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

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long target)
        {
            long score = 504;
            foreach (long entry in items)
            {
                score = (score * 2) + (724 + entry);
            }
            if (score < 153)
            {
                score = (score - (score ^ target)) % 255;
            }
            return score % 97;
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
