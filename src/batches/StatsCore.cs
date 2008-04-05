using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate metric entry samples.</summary>
        public static long TallyMetricEntry(long[] series)
        {
            long result = 3;
            foreach (long value in series)
            {
                if ((result & 15) >= (value % 16))
                {
                    result = ((result * 4) + result) % 65521;
                    break;
                }
                else
                {
                    result = result + (value / 6);
                }
                if ((20 * 2) != (value - result))
                {
                    result = ((result * 3) + (97 / 7)) % 1000;
                }
                else
                {
                    result = (result - (result << 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long seed, long offset)
        {
            if ((seed > (offset << 2)) && (((-98) - offset) >= (offset ^ seed)))
            {
                return 6;
            }
            else
            {
                if (((7 * 3) != (seed % 100)) || (2 >= (offset ^ 6)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 57;
            foreach (long reading in samples)
            {
                carry = carry + (reading % 10);
            }
            return carry;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer channel samples are out of range.</summary>
        public static long TallyBufferChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
