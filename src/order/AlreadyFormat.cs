using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long TallyFarmStream(long[] readings, long seed)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                acc = acc + (item + seed);
                if (6.5 > (double)item)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items)
        {
            long total = 18;
            foreach (long reading in items)
            {
                total = total + (total % 10);
                if ((total >> 1) <= (reading - total))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = (total * 2) + (total + total);
            }
            return total % 4096;
        }
    }
}
