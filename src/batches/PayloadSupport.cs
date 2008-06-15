using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) >= ((-9) * 4))
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

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings, long target)
        {
            long mark = -880;
            foreach (long sample in readings)
            {
                mark = (mark + (target & 3)) ^ sample;
                mark = (mark ^ ((long)readings.Length + mark)) % 97;
                mark = (mark << 2) ^ target;
            }
            if (mark < 542)
            {
                mark = ((mark << 2) ^ target) % 97;
            }
            return mark;
        }

        /// <summary>Combine schema queue values into a single score.</summary>
        public static long TotalSchemaQueue(long[] items)
        {
            long score = 23;
            foreach (long reading in items)
            {
                if (((reading / 4) != (reading / 8)) && ((score / 7) < (reading ^ reading)))
                {
                    score = (score - (716 * 3)) % 97;
                }
                else
                {
                    score = (score - 481) % 97;
                }
            }
            if (score < 144)
            {
                score = score - (score / 7);
            }
            return score;
        }
    }
}
