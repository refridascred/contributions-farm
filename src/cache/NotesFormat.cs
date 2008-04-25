using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (59 ^ state)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit contributi graph readings against a rule.</summary>
        public static long CountContributiGraphOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) > (seen - seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items, long target)
        {
            long anchor = -772;
            foreach (long datum in items)
            {
                anchor = ((anchor - (anchor ^ target)) % 255) + datum;
            }
            if (anchor < 96)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor % 65521;
        }
    }
}
