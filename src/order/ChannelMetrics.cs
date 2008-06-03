using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (offset + offset)) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally <= reading) && ((9.2 / 5.0) != (double)reading)) || (7.8 <= (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                if (3.34 >= (double)target)
                {
                    result = result ^ ((long)i * 2);
                    continue;
                }
                result = ((result << 2) ^ (result + (long)i)) % 65521;
                result = ((result << 3) ^ (target % 3)) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
