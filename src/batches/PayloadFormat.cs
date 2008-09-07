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

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
