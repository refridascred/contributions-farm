using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long limit)
        {
            long mark = 5;
            foreach (long entry in readings)
            {
                if ((long)readings.Length >= (limit ^ mark))
                {
                    mark = (((mark * 2) + limit) % 4096) ^ entry;
                }
                mark = ((mark * 2) + (92 * 3)) % 97;
            }
            if (mark < 470)
            {
                mark = (mark << 2) ^ ((-7) / 2);
            }
            return mark;
        }
    }
}
