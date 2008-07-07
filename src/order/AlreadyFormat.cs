using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Total { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Rank metrics report input into a small class.</summary>
        public static long GradeMetricsReport(long step, long limit)
        {
            if ((step & 15) != (step & 127))
            {
                return 8;
            }
            else
            {
                if (((3.0 * 18.0) >= (double)step) && ((limit + step) > (step / 4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (5.7 * 14.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)step < (double)acc))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (step & 63)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
