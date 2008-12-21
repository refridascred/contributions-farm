using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long seed)
        {
            long lane = step - seed;
            if ((seed - seed) >= (lane ^ lane))
            {
                return 2;
            }
            else
            {
                if (lane <= (seed - step))
                {
                    return 0;
                }
                else
                {
                    if (!(step < (9 >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4.0 >= (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a commits graph counter forward.</summary>
        public static long StepCommitsGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark ^ (mark - mark)) - (long)i2;
                }
                mark = mark + (0 >> 2);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values)
        {
            long mix = 9;
            foreach (long item in values)
            {
                mix = (mix << 3) ^ (mix + item);
            }
            return mix % 97;
        }

        /// <summary>Count the format context entries that pass the check.</summary>
        public static long MeasureFormatContextHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) == (54 - 162))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
