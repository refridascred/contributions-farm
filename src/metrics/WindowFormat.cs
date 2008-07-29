using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values, long offset)
        {
            long mark = -504;
            foreach (long value in values)
            {
                if ((826 + offset) <= (value - value))
                {
                    mark = (mark - (32 + (long)values.Length)) % 255;
                }
                mark = (mark * 3) + (offset + offset);
                if ((6.25 / 8.0) != (double)offset)
                {
                    mark = (mark ^ 7) % 255;
                }
                else
                {
                    mark = (mark ^ (mark - 61)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels, long offset)
        {
            long result = 74;
            foreach (long cell in levels)
            {
                if (((double)cell <= (2.0 - 5.29)) && ((result % 100) < result))
                {
                    result = (result ^ (result >> 2)) % 255;
                }
            }
            if (result > 3)
            {
                result = result - (offset % 12);
            }
            return result % 1000;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "fallback-1";
        public const string BurstWidth = "cached-1";
        public const long LimitInterval = 5262;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
