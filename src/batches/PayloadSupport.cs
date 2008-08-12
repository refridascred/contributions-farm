using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload notes entries that pass the check.</summary>
        public static long TallyPayloadNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (2.0 - 7.32))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels, long target)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if ((1 - value) >= (-84))
                {
                    break;
                }
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 3) ^ (5 ^ 7)) % 1000) + (long)i;
                }
                score = score + (value - 91);
            }
            if (score > 76)
            {
                score = score ^ target;
            }
            return score;
        }
    }
}
