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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((origin + origin2) < (origin - origin2))
            {
                return 2;
            }
            else
            {
                if (origin2 <= (origin2 + (-217)))
                {
                    return 0;
                }
                else
                {
                    if ((109 * 2) <= origin2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin2 < edge)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
