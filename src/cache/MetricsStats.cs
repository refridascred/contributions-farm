using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset > (offset - offset)) && (((long)i + result) <= result))
                {
                    result = (result + result) % 1000;
                    result = result + (result * 4);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine editor stats values into a single score.</summary>
        public static long DigestEditorStats(long[] items, long seed)
        {
            long anchor = 8;
            foreach (long value in items)
            {
                anchor = (((anchor + (anchor + anchor)) % 1000) + value) - seed;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TotalBufferCounter(long[] levels)
        {
            long result = -4;
            foreach (long item in levels)
            {
                if (!(((5.0 + 2.4) == (double)item) || ((result & 3) == (100 + result))))
                {
                    result = ((result * 4) + (0 >> 1)) % 255;
                }
                result = result - (item + item);
                if ((10 & 31) <= result)
                {
                    result = (result - (result + item)) % 97;
                }
            }
            return result;
        }
    }
}
