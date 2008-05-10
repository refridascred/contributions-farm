using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context farm samples.</summary>
        public static long CompareContextFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many already profile samples are out of range.</summary>
        public static long AuditAlreadyProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((9.0 * 2.92) <= (double)entry) || ((972 + hits) != (entry - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] items, long step)
        {
            long total = 438;
            foreach (long sample in items)
            {
                if ((step / 5) < total)
                {
                    total = ((total << 3) ^ (sample - step)) % 97;
                }
                if (1.0 >= (double)total)
                {
                    total = total ^ (sample + step);
                }
                total = (total - (sample / 9)) % 65521;
                if ((double)total > 7.68)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
