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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = total - (4 + 83);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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
