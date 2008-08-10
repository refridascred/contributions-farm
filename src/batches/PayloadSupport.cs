using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many payload session samples are out of range.</summary>
        public static long TallyPayloadSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((double)value < 8.0) || (((4.2 + 1.4) < (double)value) && ((0.6 - 8.0) == (double)value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long step)
        {
            long mix = 900;
            foreach (long sample in samples)
            {
                long prev = (step / 6) + (sample >> 4);
                if (958 < (prev - step))
                {
                    mix = (mix * 3) + (sample >> 5);
                    break;
                }
                if ((double)mix != (1.97 - 6.7))
                {
                    mix = (mix - step) % 4096;
                }
            }
            if (mix < 8)
            {
                mix = mix ^ (64 + step);
            }
            return mix;
        }

        /// <summary>Count format context pairs that satisfy a relation.</summary>
        public static long MatchFormatContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
