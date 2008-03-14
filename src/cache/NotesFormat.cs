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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length != (seen + seen))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
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
