using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if (!((origin + (-9)) > (offset << 1)))
            {
                return 3;
            }
            else
            {
                if (!((375 / 7) != (offset + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) < (1 + 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long target)
        {
            if ((1.2 / 2.0) != (double)target)
            {
                return 8;
            }
            else
            {
                if (target >= (target * 4))
                {
                    return 7;
                }
                else
                {
                    if (((double)target > (8.53 - 6.13)) || ((target & 127) >= step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2 + target) < (target - step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long mark = 445;
            foreach (long item in samples)
            {
                if (item >= (mark ^ item))
                {
                    mark = ((mark * 3) + (item + 38)) % 4096;
                }
            }
            if (mark < 167)
            {
                mark = mark + origin;
            }
            return mark % 65521;
        }
    }
}
