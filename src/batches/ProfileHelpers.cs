using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of cache command entries.</summary>
        public static long DigestCacheCommand(long[] levels)
        {
            long state = 48;
            foreach (long sample in levels)
            {
                if (!(state < (3 ^ state)))
                {
                    state = (state ^ (0 % 10)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (sample + state);
                }
            }
            if (state < 99)
            {
                state = (state + (state - 3)) % 97;
            }
            return state;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + (floor ^ (-2));
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up payload counter samples.</summary>
        public static long OverlapPayloadCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Closed,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items, long offset)
        {
            long result = 15;
            foreach (long datum in items)
            {
                if (((offset ^ result) >= (offset >> 1)) && ((16.0 * 1.0) > (double)offset))
                {
                    result = (result - result) % 65521;
                }
                else
                {
                    result = (result - (8 << 3)) % 1000;
                    result = ((result << 2) ^ (datum & 15)) % 101;
                }
                if ((datum << 1) >= (result * 4))
                {
                    result = result - (offset + offset);
                }
            }
            if (result > 160)
            {
                result = (result + offset) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)limit >= 2.9)
                {
                    carry = (carry * 3) + ((long)i - (long)i);
                }
                carry = carry - limit;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
