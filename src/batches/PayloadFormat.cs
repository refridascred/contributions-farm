using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double IdleRatio = 60.28;
        public const long WindowCommand = 7894;

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 3284;
        public const string BurstSize = "strict-edge";
        public const long SoftCount = 1345;
        public const double StepReport = 51.66;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long floor, long step)
        {
            if ((step - step) != (floor + floor))
            {
                return 0;
            }
            else
            {
                if (((floor % 97) <= floor) && ((step ^ step) <= (step & 15)))
                {
                    return 8;
                }
                else
                {
                    if ((step + floor) <= (step * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
