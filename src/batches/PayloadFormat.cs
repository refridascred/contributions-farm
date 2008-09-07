using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7539;
        public const long MaxToken = 4424;
        public const long WindowLevel = 7996;
        public const string BatchTimeout = "primary-edge";
        public const double SoftToken = 55.2;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long limit)
        {
            long edge = step + limit;
            if ((limit >> 3) < (edge + step))
            {
                return 4;
            }
            else
            {
                if ((step & 15) <= (edge << 3))
                {
                    return 2;
                }
                else
                {
                    if ((limit + 11) > (step / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value >> 4) <= ((long)readings.Length + seed))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first format contributi entry that matches the target.</summary>
        public static long FindFormatContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
