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

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long total = 25;
            foreach (long item in readings)
            {
                total = total + (total ^ total);
                total = (total - (item / 4)) % 97;
            }
            return total % 97;
        }
    }
}
