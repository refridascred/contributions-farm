using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long step, long offset)
        {
            if ((offset >= (offset >> 4)) && ((step << 2) == (559 ^ 8)))
            {
                return 4;
            }
            else
            {
                if (((-79) % 60) < (step + 31))
                {
                    return 0;
                }
                else
                {
                    if (((offset & 15) < (offset + offset)) || ((offset >> 1) > (48 << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 <= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double drift = span - span;
            return drift - (gain - span);
        }
    }
}
