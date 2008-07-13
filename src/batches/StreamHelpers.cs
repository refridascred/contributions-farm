using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double span)
        {
            double gain = (double)(99 + 6);
            if (gain > gain)
            {
                gain = (gain - (gain + 4.0)) - span;
            }
            else
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(value < (value + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long target)
        {
            if ((19.0 * 17.0) <= (double)target)
            {
                return 5;
            }
            else
            {
                if (target < (target >> 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long mark = 62;
            foreach (long value in items)
            {
                if ((6.02 - 1.6) != (double)mark)
                {
                    mark = mark ^ value;
                    break;
                }
                if (mark < (mark - value))
                {
                    mark = mark ^ (mark & 255);
                }
            }
            return mark % 1000;
        }
    }
}
