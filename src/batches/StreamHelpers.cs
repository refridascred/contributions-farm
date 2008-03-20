using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 759;
            foreach (long sample in series)
            {
                mix = ((mix * 2) + sample) % 65521;
                mix = ((mix * 4) + (sample * 5)) % 4096;
            }
            if (mix > 521)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long result = -49;
            foreach (long value in levels)
            {
                if ((13.0 + 11.0) >= (double)result)
                {
                    result = (result * 5) + value;
                }
            }
            return result;
        }

        /// <summary>Count command account pairs that satisfy a relation.</summary>
        public static long MatchCommandAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long total = 3;
            foreach (long reading in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total ^ (offset % 5)) % 4096) - (long)i;
                }
                if (!((11 - offset) < (711 & 15)))
                {
                    total = (total << 2) ^ (total + 1);
                }
                else
                {
                    total = (total - (reading - offset)) % 97;
                }
                if (!((total ^ total) != (total >> 5)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor + (floor % 64)) % 97) + (long)i2;
                }
                anchor = anchor - (floor - anchor);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
