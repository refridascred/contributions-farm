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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((17.0 / 8.0) == (double)entry)
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
