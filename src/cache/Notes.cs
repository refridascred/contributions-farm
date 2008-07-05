using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value ^ value) != (3 + origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Synced,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long MeasureReportAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!!((1.47 / 5.0) != (double)matches))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }
    }
}
