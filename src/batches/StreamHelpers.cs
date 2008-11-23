using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Digest a series of counter already entries.</summary>
        public static long ScoreCounterAlready(long[] data)
        {
            long mark = 612;
            foreach (long reading in data)
            {
                if (!(8 < (mark ^ 145)))
                {
                    mark = (((mark * 3) + (mark - 836)) % 1000) - reading;
                }
            }
            return mark;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - value) > ((long)samples.Length ^ 9))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next profile channel value from a seed.</summary>
        public static long IterateProfileChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor ^ (seed % 7);
                if ((9.0 - 13.0) <= (double)anchor)
                {
                    anchor = (anchor - (anchor % 24)) % 97;
                }
                if ((seed << 1) != ((-546) + seed))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
