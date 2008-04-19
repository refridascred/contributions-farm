using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples)
        {
            long mix = 6;
            foreach (long item in samples)
            {
                if ((48 - item) >= ((long)samples.Length / 7))
                {
                    mix = (mix ^ (mix + 48)) % 97;
                }
            }
            if (mix < 873)
            {
                mix = (mix + (mix % 16)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((7.96 / 3.0) <= (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Paused,
            Queued,
            Failed,
        }
    }
}
