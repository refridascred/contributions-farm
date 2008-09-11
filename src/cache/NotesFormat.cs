using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Pending,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double bias)
        {
            double drift = bias;
            if (drift >= 11.0)
            {
                drift = (drift + (double)7) - rate;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + 7.84;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings, long seed)
        {
            long anchor = 656;
            foreach (long reading in readings)
            {
                anchor = (anchor + (10 + seed)) + reading;
                anchor = (anchor ^ (anchor % 60)) % 65521;
            }
            if (anchor > (-820))
            {
                anchor = ((anchor * 5) + (anchor % 8)) % 97;
            }
            return anchor % 97;
        }
    }
}
