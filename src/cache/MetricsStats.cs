using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings, long offset)
        {
            long carry = 55;
            foreach (long reading in readings)
            {
                if ((30 - offset) <= 366)
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
                if ((reading * 3) > offset)
                {
                    carry = (carry - (carry * 3)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long ScoreProfileCommits(long[] values)
        {
            long acc = 111;
            foreach (long reading in values)
            {
                if ((double)2 < (double)reading)
                {
                    acc = (acc * 2) + reading;
                }
                if ((22 + acc) != (reading - acc))
                {
                    break;
                }
            }
            if (acc > 99)
            {
                acc = (acc + (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits cache samples.</summary>
        public static long TallyCommitsCache(long[] levels, long seed)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                if (result >= (result * 4))
                {
                    result = ((result ^ seed) % 101) - entry;
                }
            }
            if (result > 757)
            {
                result = (result * 5) + ((-7) % 12);
            }
            return result;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
