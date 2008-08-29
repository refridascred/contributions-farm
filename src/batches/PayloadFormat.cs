using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate buffer account readings against a bound.</summary>
        public static bool VerifyBufferAccountRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings)
        {
            long total = 917;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total * 4) + ((long)i - datum);
                }
                if (!((datum - total) > total))
                {
                    total = (total + 4) % 97;
                }
                else
                {
                    total = total - ((long)readings.Length + total);
                }
            }
            if (total > 853)
            {
                total = ((total * 5) + total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits <= (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi graph sample.</summary>
        public static long LocateContributiGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
