using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank profile notes input into a small class.</summary>
        public static long GradeProfileNotes(long seed, long bound)
        {
            long edge = seed - bound;
            if ((bound - bound) == (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (12.0 + 0.8))
                {
                    return 7;
                }
                else
                {
                    if (((14.0 + 9.12) != (double)edge) && (edge <= (seed / 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed <= 4.32)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Idle,
            Pending,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)step)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
