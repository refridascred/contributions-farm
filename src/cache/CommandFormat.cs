using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((9.0 / 8.0) < (double)item)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long seed)
        {
            if (((18.0 / 3.0) < (9.8 * 2.1)) || ((double)limit <= (0.75 * 1.0)))
            {
                return 6;
            }
            else
            {
                if (!(2 <= (seed * 4)))
                {
                    return 7;
                }
                else
                {
                    if ((seed - 237) != (seed & 255))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-516) - 7) >= (limit & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
