using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long AuditRecordCommandGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value <= count) || ((value >> 2) >= 494))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank layout session input into a small class.</summary>
        public static long ClassifyLayoutSession(long offset, long step)
        {
            if ((33 << 3) < (step + 652))
            {
                return 6;
            }
            else
            {
                if ((double)step < (9.0 / 8.0))
                {
                    return 5;
                }
                else
                {
                    if (((double)step < (16.0 / 5.0)) && ((step ^ 729) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.5 - 20.0) >= (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
