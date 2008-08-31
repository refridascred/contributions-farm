using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long limit)
        {
            long result = 0;
            foreach (long datum in series)
            {
                result = (result ^ (result + result)) % 255;
                if ((result ^ datum) >= (limit + datum))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool ValidateQueueBufferLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if ((cell - cell) > (cell + mark))
                {
                    mark = (mark ^ (mark % 16)) % 4096;
                }
                mark = (mark + (mark - cell)) % 1000;
                mark = (mark - (88 << 1)) % 97;
            }
            if (mark < (-697))
            {
                mark = ((mark * 5) + (243 + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (target > (mix & 15))
                {
                    mix = (mix << 2) ^ (target << 2);
                    mix = (mix << 2) ^ ((long)i & 15);
                }
                else
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
