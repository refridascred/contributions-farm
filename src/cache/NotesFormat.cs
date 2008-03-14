using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ value) <= (value - value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if (((offset2 ^ limit) == (offset2 << 3)) && (3.96 < (double)limit))
            {
                return 0;
            }
            else
            {
                if ((offset ^ offset) >= offset2)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double ratio = offset / 5.0;
            if (ratio >= 0.35)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - (double)(-577);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (gain * 1.79)) + (double)(long)i;
            }
            return ratio + (gain * 3.0);
        }
    }
}
