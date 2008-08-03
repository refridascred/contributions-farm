using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of payload farm readings.</summary>
        public static long PairPayloadFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 << 2) >= count)
                {
                    count = ((count + 2) ^ cell) + target;
                }
            }
            return count;
        }
    }
}
