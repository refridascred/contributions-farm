using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long offset)
        {
            long span = seed ^ offset;
            if (((4 - seed) != (offset - (-709))) && ((seed / 9) != (61 << 3)))
            {
                return 2;
            }
            else
            {
                if ((0.8 / 7.0) > (double)span)
                {
                    return 6;
                }
                else
                {
                    if ((span >> 4) < offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset ^ offset) >= (seed / 2)) && ((40 >> 1) <= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double rate2 = rate;
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 + 15.0) + (double)(long)i) + offset;
            }
            return rate2 + (rate / 4.0);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
