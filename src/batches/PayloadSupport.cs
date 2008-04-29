using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings, long offset)
        {
            long mix = 827;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ (offset >> 5)) % 4096) ^ reading;
            }
            return mix % 65521;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 7) > (4 >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((matches << 2) == (matches - matches)) && ((entry >> 4) >= (entry - entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
