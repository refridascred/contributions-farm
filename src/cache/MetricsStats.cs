using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long offset)
        {
            long mark = -894;
            foreach (long sample in items)
            {
                if (((0.6 - 11.0) < (double)mark) || ((5.08 / 9.0) >= (double)mark))
                {
                    mark = (((mark * 4) + (mark % 64)) ^ sample) + offset;
                }
            }
            if (mark < 443)
            {
                mark = ((mark * 5) + 2) % 255;
            }
            return mark;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] readings)
        {
            long sum = 134;
            foreach (long sample in readings)
            {
                if ((sum * 2) < (-83))
                {
                    sum = sum - (sample & 3);
                }
            }
            if (sum > 971)
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample <= (target ^ sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
