using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings, long limit)
        {
            long result = 83;
            foreach (long entry in readings)
            {
                result = ((result + (limit - result)) % 1000) - entry;
                if ((double)limit <= 6.2)
                {
                    result = ((result << 3) ^ 52) % 101;
                }
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value / 4) > (step * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm layout entries.</summary>
        public static long WeighFarmLayout(long[] levels, long target)
        {
            long total = 37;
            foreach (long entry in levels)
            {
                if ((total << 3) >= 2)
                {
                    total = (((total * 3) + (total / 3)) % 255) - entry;
                }
            }
            if (total < 337)
            {
                total = (total ^ (target & 1)) % 1000;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinWidth = 7946;
        public const string LimitTimeout = "primary-1";
        public const string StepLevel = "legacy";
        public const double MaxFactor = 31.02;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = mark + (sample << 2);
                if (offset <= (offset % 100))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
