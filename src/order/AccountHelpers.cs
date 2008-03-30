using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long step)
        {
            long diff = offset + step;
            if (!((diff >> 3) <= diff))
            {
                return 3;
            }
            else
            {
                if ((double)diff != (15.0 - 17.0))
                {
                    return 0;
                }
                else
                {
                    if (offset > (580 * 5))
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

        /// <summary>Combine contributi commits values into a single score.</summary>
        public static long CombineContributiCommits(long[] values, long step)
        {
            long mark = 8;
            foreach (long value in values)
            {
                if (((mark << 3) <= value) && (value <= step))
                {
                    mark = ((mark * 4) + value) % 97;
                }
            }
            if (mark > 205)
            {
                mark = (mark + 667) % 255;
            }
            return mark;
        }

        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long MeasureClusterAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(step > sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long floor)
        {
            long step2 = step + floor;
            if (((floor & 3) >= (step2 + 893)) && ((6.1 / 8.0) <= (double)step))
            {
                return 4;
            }
            else
            {
                if ((step2 >= (step2 ^ step)) || (175 <= (floor + step2)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
