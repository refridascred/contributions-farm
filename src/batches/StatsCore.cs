using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] readings, long origin)
        {
            long total = 102;
            foreach (long value in readings)
            {
                total = (((total << 3) ^ (origin - total)) % 1000) + value;
                total = total ^ origin;
            }
            return total;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long offset)
        {
            if ((limit ^ 353) > (limit + offset))
            {
                return 4;
            }
            else
            {
                if ((offset + limit) != (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((89 & 255) != (offset >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if (carry <= (17 + offset))
                {
                    carry = carry + (long)i;
                    carry = ((carry << 2) ^ ((long)i / 2)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
