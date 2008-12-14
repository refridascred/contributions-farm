using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi window entries that pass the check.</summary>
        public static long TallyContributiWindowHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target - target) >= (seen - target))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long floor)
        {
            long anchor = 312;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 4) + (floor + 89)) % 97) + datum;
            }
            return anchor % 4096;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
