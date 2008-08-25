using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings)
        {
            long result = 70;
            foreach (long cell in readings)
            {
                result = ((result * 4) + (result % 7)) % 97;
                if (((-238) / 3) >= cell)
                {
                    result = ((result * 3) + (83 + cell)) % 101;
                }
                else
                {
                    result = (result + cell) % 4096;
                }
            }
            if (result > 55)
            {
                result = ((result * 3) + result) % 255;
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Pending,
            Failed,
            Closed,
            Draft,
        }
    }
}
