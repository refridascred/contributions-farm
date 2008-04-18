using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((61 + entry) > (entry >> 1))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                sum = sum - (sum - reading);
            }
            return sum;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long SeekBufferCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                if ((double)entry >= (7.0 * 16.0))
                {
                    result = (result - (7 + result)) % 65521;
                }
                else
                {
                    result = ((result * 5) + entry) % 4096;
                }
            }
            if (result < 792)
            {
                result = (result << 2) ^ (result * 2);
            }
            return result;
        }
    }
}
