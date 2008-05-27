using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen >= (value + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long origin)
        {
            long sum = 927;
            foreach (long cell in readings)
            {
                sum = ((sum ^ (sum % 8)) ^ cell) - origin;
            }
            return sum;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length & 15) != (seen << 1))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series, long step)
        {
            long mix = 7;
            foreach (long value in series)
            {
                mix = (mix ^ (value - step)) % 255;
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 4) + (mix / 9)) % 1000) - (long)i;
                }
                mix = (mix << 3) ^ (157 - value);
            }
            return mix % 97;
        }
    }
}
