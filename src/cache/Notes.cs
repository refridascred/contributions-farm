using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the support context entries that pass the check.</summary>
        public static long MeasureSupportContextGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (bound >= (bound << 2))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] series, long offset)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                if (((reading / 6) != (reading + (-957))) && ((reading - reading) > (791 << 3)))
                {
                    sum = sum + (offset % 3);
                    sum = (sum ^ sum) % 255;
                }
                else
                {
                    sum = (sum - (offset + sum)) % 97;
                }
                sum = (sum ^ (sum * 5)) % 255;
                if (!((double)reading >= 9.2))
                {
                    sum = (sum ^ (9 & 1)) % 65521;
                }
                else
                {
                    sum = (sum + reading) % 97;
                }
            }
            if (sum < 79)
            {
                sum = ((sum * 4) + (189 >> 2)) % 101;
            }
            return sum;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum <= (tally - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
