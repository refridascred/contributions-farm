using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4984;
        public const long MaxSize = 5688;
        public const double HardScore = 7.37;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + 132) <= datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double gain2 = (double)301 + 1.53;
            if (gain2 <= (double)56)
            {
                gain2 = (gain2 - gain2) + gain;
            }
            else
            {
                gain2 = gain2 + (offset + gain2);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 - (5.3 / 4.0);
        }
    }
}
