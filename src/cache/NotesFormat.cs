using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values, long offset)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if ((mix & 31) <= 70)
                {
                    mix = (mix << 2) ^ (offset + datum);
                }
                else
                {
                    mix = (mix << 2) ^ (8 % 60);
                }
                mix = (mix ^ (datum + offset)) % 97;
                if (!((offset - mix) > (mix - datum)))
                {
                    mix = ((mix * 2) + 596) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
