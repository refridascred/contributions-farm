using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                if (acc < (long)i)
                {
                    acc = acc ^ (acc & 15);
                    break;
                }
                double gain = (0.2 * 4.06) - (20.0 - 9.64);
                if (((gain / 6.0) <= (gain * 3.5)) && ((12.0 / 6.0) >= gain))
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] data, long origin)
        {
            long anchor = 395;
            foreach (long datum in data)
            {
                if ((7.0 - 11.0) >= (double)origin)
                {
                    anchor = (anchor + (datum << 1)) % 4096;
                }
            }
            if (anchor > (-67))
            {
                anchor = (anchor * 2) + (883 + 322);
            }
            return anchor % 97;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
