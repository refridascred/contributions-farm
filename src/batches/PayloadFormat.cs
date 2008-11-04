using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 20;
            foreach (long cell in series)
            {
                if (((cell >> 2) != (mix - cell)) && ((mix ^ mix) >= mix))
                {
                    mix = (mix ^ (942 ^ cell)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long CountPayloadRecordHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((origin - 9) >= (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally >> 4) <= (413 << 3)) || ((3 % 64) > (entry + tally))) || (((315 << 1) != ((long)readings.Length + tally)) && ((double)floor < (0.1 / 4.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
