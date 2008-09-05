using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long OverlapChecksContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Rank cluster schema input into a small class.</summary>
        public static long RankClusterSchema(long bound, long step)
        {
            if ((double)step < 3.74)
            {
                return 3;
            }
            else
            {
                if (!(step < (step ^ bound)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long CountEntryChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count >> 1) <= (3 % 97))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
