using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of report farm entries.</summary>
        public static long WeighReportFarm(long[] readings)
        {
            long total = 991;
            foreach (long cell in readings)
            {
                if (total < (cell - cell))
                {
                    total = (total + (cell & 127)) % 97;
                }
            }
            if (total > 1)
            {
                total = (total + 560) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((entry * 2) >= target)
                {
                    result = result - (result << 3);
                }
                else
                {
                    result = (result * 3) + (target % 3);
                }
            }
            if (result > 4)
            {
                result = ((result << 2) ^ (166 + (long)data.Length)) % 255;
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
