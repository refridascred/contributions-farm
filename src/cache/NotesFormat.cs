using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long result = 505;
            foreach (long entry in data)
            {
                result = ((result << 3) ^ (result + entry)) % 4096;
            }
            return result;
        }

        /// <summary>Grade a batches checks value against two limits.</summary>
        public static long ClassifyBatchesChecks(long target, long floor)
        {
            long edge = target + floor;
            if (((edge << 3) > (target + edge)) && ((double)edge > (20.0 - 16.0)))
            {
                return 8;
            }
            else
            {
                if (edge <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if (((floor + floor) > (floor % 60)) && ((edge + floor) >= edge))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Paused,
            Queued,
        }
    }
}
