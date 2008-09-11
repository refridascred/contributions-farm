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

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                if (((5 % 97) < (sample % 2)) || ((3.2 + 7.0) != (double)sample))
                {
                    mark = mark ^ (sample + sample);
                }
            }
            return mark;
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
