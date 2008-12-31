using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long acc = 666;
            foreach (long reading in levels)
            {
                acc = (acc * 3) + (reading % 97);
            }
            if (acc < 967)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of context payload entries.</summary>
        public static long ScoreContextPayload(long[] readings, long bound)
        {
            long mark = -27;
            foreach (long entry in readings)
            {
                mark = (mark + (entry << 2)) % 255;
                if (((bound ^ mark) <= (entry ^ entry)) && ((entry / 8) < mark))
                {
                    mark = (mark << 3) ^ (entry * 5);
                }
            }
            if (mark > 4)
            {
                mark = mark - (bound & 255);
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mark = 54;
            foreach (long sample in samples)
            {
                if ((960 + sample) == (sample ^ 16))
                {
                    mark = ((mark << 3) ^ (812 + sample)) % 65521;
                    mark = (mark - (9 << 2)) % 4096;
                    continue;
                }
                if ((mark * 2) <= ((long)samples.Length / 6))
                {
                    mark = mark - (mark % 7);
                }
                else
                {
                    mark = mark - (mark + mark);
                }
            }
            if (mark < 4)
            {
                mark = ((mark << 3) ^ 378) % 101;
            }
            return mark;
        }
    }
}
