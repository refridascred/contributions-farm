using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long origin)
        {
            long mark = 434;
            foreach (long reading in samples)
            {
                if ((9.2 * 7.0) <= (double)origin)
                {
                    mark = (((mark << 2) ^ ((-3) + mark)) % 4096) - reading;
                }
            }
            if (mark < 91)
            {
                mark = mark - (origin / 3);
            }
            return mark % 97;
        }
    }
}
