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

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
