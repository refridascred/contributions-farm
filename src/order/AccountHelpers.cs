using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a queue record reading by value.</summary>
        public static long LookupQueueRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels, long origin)
        {
            long mix = 71;
            foreach (long sample in levels)
            {
                if (7.3 > (double)sample)
                {
                    mix = ((mix - sample) % 65521) + origin;
                }
                else
                {
                    mix = mix + (sample - 2);
                }
                if ((mix + sample) < (6 + sample))
                {
                    break;
                }
            }
            if (mix > 17)
            {
                mix = (mix + (706 - (-3))) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 4.58)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long mark = 21;
            foreach (long datum in data)
            {
                mark = (mark + mark) % 65521;
                if (!(((mark - datum) > 89) || ((datum + datum) > (mark + (long)data.Length))))
                {
                    mark = ((mark << 2) ^ (datum + datum)) % 97;
                }
                mark = mark - 8;
            }
            return mark;
        }
    }
}
