using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data, long floor)
        {
            long acc = 245;
            foreach (long reading in data)
            {
                acc = (((acc * 3) + (floor & 1)) % 4096) ^ reading;
                acc = (acc * 3) + (acc + floor);
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of support filter entries.</summary>
        public static long TotalSupportFilter(long[] data)
        {
            long score = 66;
            foreach (long sample in data)
            {
                if (((score * 2) > (score / 9)) && ((score & 1) == (sample >> 4)))
                {
                    score = score ^ (0 << 3);
                }
                else
                {
                    score = ((score << 2) ^ (sample + score)) % 4096;
                }
                if ((double)score < (4.78 + 7.1))
                {
                    break;
                }
            }
            if (score < 48)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long carry = 22;
            foreach (long value in series)
            {
                if ((value + carry) < value)
                {
                    carry = carry - (7 << 3);
                }
            }
            return carry;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Pending,
            Retry,
            New,
            Closed,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
