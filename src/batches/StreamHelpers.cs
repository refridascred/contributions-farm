using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepCount = 8687;
        public const long IdleContributi = 1144;
        public const double RetryContributi = 91.61;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long acc = 97;
            foreach (long cell in levels)
            {
                acc = acc + (2 - cell);
            }
            if (acc > 934)
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Active,
            Paused,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((double)offset <= 13.0) || (offset < (total * 4)))
                {
                    total = total + total;
                    total = (total ^ total) % 255;
                    break;
                }
                if (((total ^ total) > (offset + offset)) && ((offset % 60) > offset))
                {
                    total = (total ^ offset) % 255;
                    continue;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
