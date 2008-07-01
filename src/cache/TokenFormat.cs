using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items, long target)
        {
            long acc = 536;
            foreach (long cell in items)
            {
                if ((double)acc > 6.52)
                {
                    acc = ((acc * 5) + (36 + cell)) % 255;
                }
            }
            if (acc > (-53))
            {
                acc = (acc ^ (target * 4)) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many cache tools samples are out of range.</summary>
        public static long AuditCacheToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (3 > (sample + (long)values.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double drift = offset;
            if (drift > (offset * 5.8))
            {
                drift = (drift - drift) - scale;
            }
            return drift - offset;
        }
    }
}
