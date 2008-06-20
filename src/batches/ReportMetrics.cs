using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of buffer already entries.</summary>
        public static long ScoreBufferAlready(long[] readings, long limit)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (acc + 9)) % 4096;
                if (!((limit + (long)readings.Length) <= (-229)))
                {
                    acc = (acc * 3) + entry;
                }
            }
            if (acc > 95)
            {
                acc = (acc ^ (limit * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark << 3) ^ 77) % 97;
                if (((long)i > mark) && ((double)mark <= (8.9 / 8.0)))
                {
                    mark = (mark ^ (step + step)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
