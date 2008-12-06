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

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long floor)
        {
            long step = limit + floor;
            if (((limit - step) == (step ^ step)) || (5.95 < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((limit - step) <= limit)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
