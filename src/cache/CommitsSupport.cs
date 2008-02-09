using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(sample >= (6 + 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry schema readings.</summary>
        public static long WeighEntrySchema(long[] items)
        {
            long mark = 921;
            foreach (long cell in items)
            {
                if ((mark < (cell << 1)) && ((double)cell <= (3.0 * 2.0)))
                {
                    mark = mark + (mark & 15);
                }
                else
                {
                    mark = mark + mark;
                }
                if ((double)mark >= (8.15 * 0.6))
                {
                    mark = ((mark * 3) + (cell / 9)) % 4096;
                }
                else
                {
                    mark = mark + (cell >> 5);
                }
            }
            if (mark > 635)
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long origin, long limit)
        {
            long cur = origin - limit;
            if ((origin + origin) < (limit & 31))
            {
                return 5;
            }
            else
            {
                if (cur < (origin << 2))
                {
                    return 0;
                }
                else
                {
                    if ((origin ^ limit) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] readings)
        {
            long carry = 1;
            foreach (long value in readings)
            {
                if ((carry >= (carry & 15)) && (carry <= (carry & 31)))
                {
                    carry = (carry - ((-546) + carry)) % 4096;
                }
                else
                {
                    carry = (carry ^ (value % 97)) % 65521;
                }
            }
            if (carry < 994)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }
    }
}
