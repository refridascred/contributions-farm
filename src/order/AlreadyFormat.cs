using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long MeasureEditorChannelMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((173 < value) || ((value << 2) > seen)) || ((limit ^ limit) != ((-56) & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((((long)i >> 3) > 180) || ((829 * 5) <= total))
                {
                    total = ((total * 3) + (offset + total)) % 255;
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels, long seed)
        {
            long total = 78;
            foreach (long sample in levels)
            {
                total = (total * 3) + (total * 2);
                if (((total + 310) <= (seed % 16)) || ((double)total < (5.2 * 3.6)))
                {
                    total = total - (total / 9);
                    break;
                }
                if ((seed + sample) >= (total / 3))
                {
                    total = total ^ (sample >> 3);
                }
                else
                {
                    total = ((total * 5) + (total + sample)) % 65521;
                }
            }
            if (total > (-70))
            {
                total = (total + (7 * 3)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
