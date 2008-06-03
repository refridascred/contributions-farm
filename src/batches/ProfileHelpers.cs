using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long step)
        {
            long mark = 555;
            foreach (long cell in data)
            {
                mark = ((mark << 3) ^ (2 * 5)) % 255;
                if ((5.92 + 15.0) < (double)cell)
                {
                    mark = ((mark * 4) + (mark - 987)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (cell >> 5);
                }
                if ((step + step) < cell)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9508;
        public const long CacheOrder = 3122;
        public const long MaxRatio = 7156;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] data, long origin)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                if (((double)reading < (6.8 * 10.0)) || ((double)carry < 9.8))
                {
                    carry = (((carry * 3) + (26 / 2)) % 1000) + origin;
                }
                else
                {
                    carry = carry + (reading << 2);
                }
            }
            if (carry > 360)
            {
                carry = (carry - (carry << 2)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the commits tools series from a seed.</summary>
        public static long StepCommitsTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
