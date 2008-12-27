using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels, long limit)
        {
            long mix = 605;
            foreach (long reading in levels)
            {
                if (((7 + mix) == (5 - reading)) && (limit > (limit * 4)))
                {
                    mix = (mix + ((long)levels.Length << 2)) % 255;
                }
                else
                {
                    mix = mix + (reading + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit support stats readings against a rule.</summary>
        public static long TallySupportStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + value) >= (seen >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a command session pair into a bucket.</summary>
        public static long SortCommandSession(long offset, long step)
        {
            long gap = offset - step;
            if (((offset * 3) >= (gap / 2)) && ((gap + gap) < step))
            {
                return 8;
            }
            else
            {
                if ((gap ^ 3) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (4.0 + 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
