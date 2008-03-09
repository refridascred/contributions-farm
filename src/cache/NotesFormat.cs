using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a support checks pair into a bucket.</summary>
        public static long SortSupportChecks(long floor, long bound)
        {
            long span = floor + bound;
            if (!(floor < (span & 31)))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)floor <= (double)7)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound <= span) && (span <= (bound + span)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload batch entry stays within the limit.</summary>
        public static bool GuardPayloadBatchBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
