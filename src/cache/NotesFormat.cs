using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels)
        {
            long anchor = 678;
            foreach (long datum in levels)
            {
                if (!((double)datum < (19.0 / 9.0)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
                if ((datum + anchor) != (anchor & 7))
                {
                    anchor = (anchor - (datum - datum)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Active,
            Idle,
        }
    }
}
