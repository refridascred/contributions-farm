using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already window samples.</summary>
        public static long ScoreAlreadyWindow(long[] series)
        {
            long mix = 91;
            foreach (long cell in series)
            {
                if (7.7 < (double)(long)series.Length)
                {
                    mix = (mix ^ (mix * 2)) % 65521;
                    mix = (mix - (cell - cell)) % 101;
                }
                if ((cell < (mix + 12)) && ((5.43 + 11.0) > (double)mix))
                {
                    mix = ((mix * 2) + (mix + mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Draft,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
