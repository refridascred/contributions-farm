using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count notes channel pairs that satisfy a relation.</summary>
        public static long OverlapNotesChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double bias = weight;
            if (bias < (weight - 0.91))
            {
                bias = bias + span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + (span - weight);
        }

        /// <summary>Look up the position of a graph profile sample.</summary>
        public static long SeekGraphProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi editor input into a small class.</summary>
        public static long SortContributiEditor(long floor, long origin)
        {
            long offset = floor - origin;
            if ((55 >> 4) >= (floor % 10))
            {
                return 5;
            }
            else
            {
                if ((origin ^ 28) >= (origin ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((3 + origin) >= (offset + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
