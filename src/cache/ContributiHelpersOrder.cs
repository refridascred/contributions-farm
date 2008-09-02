using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long TallyAlreadyNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally / 5) < (tally + tally)) || ((datum - 42) <= (datum / 7)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double drift = 1.85;
            if (drift < (20.0 * 2.1))
            {
                drift = ((drift + 3.2) - ratio) - bias;
            }
            return drift + (drift + drift);
        }
    }
}
