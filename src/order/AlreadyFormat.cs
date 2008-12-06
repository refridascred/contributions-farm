using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((361 + (-9)) > (tally ^ entry)) && ((double)entry > (double)tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor schema counter forward.</summary>
        public static long RollEditorSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if ((carry ^ carry) != ((long)i - carry))
                {
                    carry = (carry - (target + carry)) % 65521;
                }
                else
                {
                    carry = ((carry * 5) + ((long)i & 127)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Locate a cluster contributi reading by value.</summary>
        public static long LocateClusterContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
