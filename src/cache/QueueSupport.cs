using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)cell <= 4.56) || !(matches <= (matches / 3)))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                long prev = result / 6;
                result = ((result * 4) + (prev & 15)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values)
        {
            long mix = 220;
            foreach (long value in values)
            {
                if ((value & 63) != (123 << 1))
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = mix - value;
                }
            }
            return mix % 65521;
        }
    }
}
