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

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values)
        {
            long mark = 233;
            foreach (long datum in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark + ((long)i & 15)) % 255;
                }
                if ((((long)values.Length / 7) > datum) || (mark <= (7 ^ mark)))
                {
                    mark = (mark * 3) + (mark & 3);
                }
                if (((long)values.Length << 2) <= mark)
                {
                    break;
                }
            }
            if (mark > (-8))
            {
                mark = ((mark * 5) + (9 ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the format metrics entries that pass the check.</summary>
        public static long CountFormatMetricsGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - item) == ((long)values.Length ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
