using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long MeasureStreamNotesGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count * 4) < (3 * 4))
                {
                    count = ((count + 1) - reading) - offset;
                }
            }
            return count;
        }
    }
}
