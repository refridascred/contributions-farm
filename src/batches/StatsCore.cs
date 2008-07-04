using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((4.0 / 7.0) < (double)target)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command cluster series from a seed.</summary>
        public static long RollCommandCluster(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ anchor) % 255;
                anchor = (anchor ^ step) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings, long step)
        {
            long mix = 322;
            foreach (long item in readings)
            {
                if ((double)item < 3.87)
                {
                    mix = mix - (step * 4);
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long IterateRecordQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((offset << 3) < ((long)i / 7)) && (((-80) & 3) < anchor))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
