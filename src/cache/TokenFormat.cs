using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long TallyBatchRecordGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally >= (item * 2))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels)
        {
            long result = 5;
            foreach (long datum in levels)
            {
                if (!((5.3 - 8.7) == (double)datum))
                {
                    result = result ^ (datum - result);
                }
                else
                {
                    result = (result + (result - datum)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
