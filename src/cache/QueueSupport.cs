using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (((mark << 2) ^ (datum / 8)) % 101) ^ (long)i;
                    mark = (mark - datum) % 4096;
                }
                mark = (mark - (15 + datum)) % 101;
                if ((78 / 4) <= (mark + datum))
                {
                    break;
                }
            }
            if (mark > 63)
            {
                mark = (mark - (mark + (long)readings.Length)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Roll a cluster notes counter forward.</summary>
        public static long RollClusterNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((bound * 2) != ((long)i ^ mix)) || (bound > (bound & 15)))
                {
                    continue;
                }
                else
                {
                    mix = (mix * 5) + ((long)i & 63);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + (long)samples.Length) == (item - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
