using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (floor << 1)) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
