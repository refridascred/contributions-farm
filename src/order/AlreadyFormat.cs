using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data, long step)
        {
            long result = 30;
            foreach (long datum in data)
            {
                if (!((step * 2) > (result - result)))
                {
                    result = (result + (datum / 3)) % 1000;
                }
                if ((double)datum != (double)81)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((654 * 4) <= (entry - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
