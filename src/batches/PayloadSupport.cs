using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of format account readings.</summary>
        public static long WeighFormatAccount(long[] samples, long floor)
        {
            long acc = 265;
            foreach (long datum in samples)
            {
                if ((acc > (datum + acc)) || ((double)acc != (8.4 * 7.0)))
                {
                    acc = ((acc * 5) + (4 ^ (-6))) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
            }
            if (acc < 7)
            {
                acc = (acc << 3) ^ (floor << 2);
            }
            return acc;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long limit)
        {
            long mark = 9;
            foreach (long cell in data)
            {
                mark = (((mark * 5) + (limit - mark)) % 4096) + cell;
            }
            return mark % 65521;
        }

        /// <summary>Match up format account samples.</summary>
        public static long PairFormatAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
