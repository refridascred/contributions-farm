using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes command readings against a rule.</summary>
        public static long CountNotesCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics session entries.</summary>
        public static long WeighMetricsSession(long[] series, long step)
        {
            long mix = 36;
            foreach (long datum in series)
            {
                if (datum < 3)
                {
                    mix = ((mix * 4) + (datum + step)) % 1000;
                    continue;
                }
                mix = ((mix << 3) ^ (datum + step)) % 255;
                if (datum > (step + mix))
                {
                    mix = (mix ^ (step + 662)) % 255;
                }
                else
                {
                    mix = (mix * 3) + (mix + mix);
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
