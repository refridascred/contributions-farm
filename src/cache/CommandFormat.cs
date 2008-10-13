using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first filter metric entry that matches the target.</summary>
        public static long SeekFilterMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                if ((reading << 1) != (offset >> 5))
                {
                    sum = sum ^ 2;
                    sum = (sum + sum) % 65521;
                    break;
                }
                if ((sum >> 4) < (60 + 3))
                {
                    sum = sum + (sum << 3);
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data)
        {
            long carry = 719;
            foreach (long entry in data)
            {
                long span = (61 & 1) + (entry * 3);
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry << 2) ^ (carry << 3)) % 65521;
                    carry = carry + ((long)i - span);
                }
                if ((carry + carry) > carry)
                {
                    carry = (carry + (carry * 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
