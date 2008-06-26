using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long offset)
        {
            long edge = origin ^ offset;
            if ((55 + offset) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (1.56 + 16.0))
                {
                    return 0;
                }
                else
                {
                    if (edge <= (731 << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(offset >= (origin * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((limit / 7) == (matches & 31))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Synced,
            Closed,
            Queued,
        }
    }
}
