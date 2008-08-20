using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 188;
            foreach (long cell in series)
            {
                carry = ((carry * 2) + ((long)series.Length + carry)) % 97;
                if (!(carry > (carry / 5)))
                {
                    carry = (carry + (cell % 2)) % 101;
                }
                if (333 > (carry >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a entry layout sample.</summary>
        public static long LookupEntryLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric commits pair into a bucket.</summary>
        public static long BucketMetricCommits(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((bound + bound) != (bound - bound2))
            {
                return 0;
            }
            else
            {
                if ((offset >> 5) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset + bound2) > 1)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
