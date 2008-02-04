using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
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
