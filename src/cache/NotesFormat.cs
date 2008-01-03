using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes command readings against a rule.</summary>
        public static long CountNotesCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double drift = (double)80 * 9.63;
            if (drift >= (weight - drift))
            {
                drift = (drift + (double)670) - floor;
            }
            else
            {
                drift = drift + (double)18;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (4.0 / 5.0)) + (double)(long)i;
            }
            return drift - (weight * 5.6);
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Ready,
            Stale,
            Queued,
        }
    }
}
