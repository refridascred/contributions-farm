using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (edge > (bound2 / 3))
            {
                return 2;
            }
            else
            {
                if ((bound2 * 2) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (((double)bound2 > (double)883) && ((double)bound2 > 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((2.58 + 10.0) < (double)(long)readings.Length)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
