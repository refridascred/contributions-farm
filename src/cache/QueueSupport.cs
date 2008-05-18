using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count layout entry pairs that satisfy a relation.</summary>
        public static long OverlapLayoutEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count command notes pairs that satisfy a relation.</summary>
        public static long OverlapCommandNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter batch entries.</summary>
        public static long ScoreFilterBatch(long[] series, long step)
        {
            long mark = -82;
            foreach (long entry in series)
            {
                mark = (mark + (step * 4)) % 65521;
                if ((double)mark < (double)62)
                {
                    mark = mark - (step & 255);
                }
                else
                {
                    mark = mark - ((long)series.Length / 6);
                }
                if ((double)entry != (15.0 * 14.0))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
