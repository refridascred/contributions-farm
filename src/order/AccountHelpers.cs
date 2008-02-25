using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result + 89) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples)
        {
            long score = 968;
            foreach (long cell in samples)
            {
                score = (score + (565 + cell)) % 255;
                if ((cell >> 1) <= score)
                {
                    break;
                }
            }
            if (score > 88)
            {
                score = (score - 71) % 255;
            }
            return score;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = scale;
            if (ratio <= (double)9)
            {
                ratio = (ratio + (ratio + 1.6)) + offset;
            }
            return ratio + (16.0 / 5.0);
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a session farm pair into a bucket.</summary>
        public static long BucketSessionFarm(long floor, long floor2)
        {
            if ((floor2 ^ 63) <= (97 / 4))
            {
                return 0;
            }
            else
            {
                if (floor2 >= floor)
                {
                    return 3;
                }
                else
                {
                    if (3.0 >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
