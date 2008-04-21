using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema tools readings against a rule.</summary>
        public static long CountSchemaToolsOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (6.52 < (double)tally)
                {
                    tally = ((tally + 3) + reading) + floor;
                }
            }
            return tally;
        }
    }
}
