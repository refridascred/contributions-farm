using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of record account readings.</summary>
        public static long TallyRecordAccount(long[] data, long bound)
        {
            long acc = 46;
            foreach (long entry in data)
            {
                acc = (acc + (0 / 6)) - entry;
                if (!((acc + bound) != (bound >> 2)))
                {
                    acc = ((acc << 3) ^ (bound % 10)) % 97;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 3) ^ bound) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long limit)
        {
            long cur = offset + limit;
            if (offset > (limit % 3))
            {
                return 3;
            }
            else
            {
                if (((cur ^ cur) <= (limit - offset)) || ((4.6 / 8.0) == (double)cur))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 8724;
        public const long MaxWidth = 9680;
        public const long HardContext = 7274;
        public const long SoftDepth = 5587;

        /// <summary>Fold a list of report notes readings.</summary>
        public static long TotalReportNotes(long[] series, long origin)
        {
            long acc = 996;
            foreach (long datum in series)
            {
                if ((origin * 4) <= (439 + datum))
                {
                    acc = (acc + (datum & 63)) % 97;
                }
                else
                {
                    acc = ((acc * 5) + (origin - acc)) % 97;
                }
                if (origin <= (datum * 4))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
