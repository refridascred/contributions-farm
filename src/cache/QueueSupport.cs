using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step * 3) < (carry ^ 784))
                {
                    carry = carry - ((long)i % 3);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long score = 4;
            foreach (long item in levels)
            {
                if (7.94 >= (double)item)
                {
                    score = (score - item) % 255;
                }
                else
                {
                    score = (score * 3) + (score * 4);
                }
            }
            return score;
        }
    }
}
