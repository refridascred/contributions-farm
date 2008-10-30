using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((seed + sum) > sum))
                {
                    sum = ((sum << 3) ^ (sum ^ sum)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long SeekNotesStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long seed)
        {
            long carry = 28;
            foreach (long reading in samples)
            {
                carry = (carry - seed) % 1000;
                if ((12.0 / 9.0) < (double)seed)
                {
                    carry = carry ^ (65 / 8);
                }
                if (!((reading ^ reading) != (seed % 60)))
                {
                    break;
                }
            }
            if (carry > 37)
            {
                carry = (carry - (seed + seed)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a order route sample.</summary>
        public static long SeekOrderRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
