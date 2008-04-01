using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next metrics stats value.</summary>
        public static double ScaleMetricsStats(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (double)(-988))
            {
                gain2 = (gain2 + (gain2 * 3.4)) - bias;
            }
            return gain2 + (gain / 8.0);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings)
        {
            long mix = 195;
            foreach (long value in readings)
            {
                mix = (mix ^ mix) % 4096;
                if ((value + 74) > 9)
                {
                    mix = mix - (value & 63);
                }
                if ((value + 0) == (mix % 64))
                {
                    mix = (mix ^ (mix - mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length <= (matches & 1))
                {
                    matches = ((matches + 1) ^ value) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((42 + 96) > hits)
                {
                    hits = ((hits + 2) + sample) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
