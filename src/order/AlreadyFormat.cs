using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCount = 8071;
        public const double WindowCache = 85.1;
        public const double LimitCache = 31.91;
        public const long SoftCache = 5985;
        public const double BaseSpan = 70.74;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Synced,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values, long offset)
        {
            long mix = -478;
            foreach (long item in values)
            {
                mix = ((mix - (792 + item)) % 97) - offset;
            }
            return mix % 97;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double weight = (double)(1 * 2);
            if (weight >= offset)
            {
                weight = weight - 3.0;
            }
            else
            {
                weight = weight - (double)551;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight - (offset * 8.16);
        }

        /// <summary>Locate a counter notes reading by value.</summary>
        public static long LookupCounterNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
