using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = state - (offset ^ offset);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state << 2) ^ (offset + (long)i2)) % 65521;
                    state = (state - (offset / 9)) % 97;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the queue buffer series from a seed.</summary>
        public static long SeriesQueueBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (2.8 > (double)sum)
                {
                    sum = ((sum << 3) ^ (step & 15)) % 65521;
                }
                if (!(step < (93 * 3)))
                {
                    sum = sum ^ (step + step);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchWidth = 3828;
        public const long BurstMetrics = 7539;
        public const long StepScore = 2639;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((origin + count) >= (count * 4))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
