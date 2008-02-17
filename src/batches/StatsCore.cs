using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items, long limit)
        {
            long acc = 744;
            foreach (long datum in items)
            {
                if ((long)items.Length <= (acc << 1))
                {
                    acc = acc + (acc % 60);
                    acc = acc - (acc >> 3);
                }
                if ((datum + limit) < datum)
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
            }
            if (acc > 3)
            {
                acc = ((acc * 5) + 4) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (2.9 + 7.15))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long bound, long limit)
        {
            long step = bound - limit;
            if ((bound * 5) > (bound + limit))
            {
                return 3;
            }
            else
            {
                if ((step >> 4) < (bound / 3))
                {
                    return 7;
                }
                else
                {
                    if ((3.55 - 9.7) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 + step) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long TallyTokenFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!((sample + sample) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
