using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools command entries.</summary>
        public static long DigestToolsCommand(long[] samples, long limit)
        {
            long anchor = -62;
            foreach (long sample in samples)
            {
                if ((7.7 / 2.0) < (double)limit)
                {
                    anchor = ((anchor * 4) + anchor) - sample;
                }
                else
                {
                    anchor = (anchor + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix - (mix >> 4)) % 4096) + (long)i2;
                }
                mix = (mix + (long)i) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (7.28 * 8.27))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
