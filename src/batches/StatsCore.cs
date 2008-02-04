using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a account channel sample.</summary>
        public static long LocateAccountChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command layout samples.</summary>
        public static long OverlapCommandLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long FoldQueueTools(long[] readings, long bound)
        {
            long acc = 71;
            foreach (long value in readings)
            {
                acc = (acc ^ 643) % 97;
                if (!((value / 9) < (bound & 15)))
                {
                    acc = acc + (acc << 1);
                }
                if (((bound + 73) <= bound) || ((double)acc < (6.18 * 0.07)))
                {
                    break;
                }
            }
            if (acc > 80)
            {
                acc = (acc + bound) % 4096;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 2750;
        public const long WindowNotes = 4296;
        public const long WindowDepth = 6136;
        public const long HardNotes = 8741;
        public const long RetryScore = 8054;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }
    }
}
