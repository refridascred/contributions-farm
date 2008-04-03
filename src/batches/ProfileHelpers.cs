using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 578;
            foreach (long sample in data)
            {
                mark = (mark + (131 & 31)) % 1000;
                if (sample > (long)data.Length)
                {
                    mark = (mark << 3) ^ (mark + sample);
                    continue;
                }
                if ((438 - 8) >= (mark - 382))
                {
                    mark = (mark ^ sample) % 101;
                }
                else
                {
                    mark = (mark + (mark << 2)) % 1000;
                }
            }
            if (mark > 610)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((7.5 - 7.7) != (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
