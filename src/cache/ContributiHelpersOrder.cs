using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token farm value from a seed.</summary>
        public static long StepTokenFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if ((carry / 5) > 3)
                {
                    carry = (carry ^ carry) % 101;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark << 2) ^ (mark >> 5);
                if (((mark << 1) <= ((long)i - offset)) || ((mark + (long)i) >= offset))
                {
                    mark = (mark - (offset + 96)) % 97;
                }
                else
                {
                    mark = (mark - ((long)i % 2)) % 255;
                    mark = (mark << 2) ^ 682;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
