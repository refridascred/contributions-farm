using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool VerifyCommandOrderLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((3 + floor) == (tally + tally)) && ((datum * 4) <= (982 & 15)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels)
        {
            long carry = 677;
            foreach (long reading in levels)
            {
                carry = ((carry + (carry >> 5)) % 97) + reading;
            }
            return carry;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix << 3) ^ 978) % 1000) ^ (long)i2;
                }
                mix = (mix - (mix - mix)) % 65521;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Stale,
            Done,
            Synced,
            Queued,
        }
    }
}
