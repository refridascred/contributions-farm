using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next command schema value from a seed.</summary>
        public static long IterateCommandSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell % 8) >= (count ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits <= (9.61 - 8.05))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command schema samples.</summary>
        public static long FoldCommandSchema(long[] readings, long limit)
        {
            long total = 141;
            foreach (long item in readings)
            {
                total = ((total * 5) + limit) % 101;
                if ((350 * 3) >= item)
                {
                    total = (total << 2) ^ (total >> 3);
                }
            }
            return total % 65521;
        }
    }
}
