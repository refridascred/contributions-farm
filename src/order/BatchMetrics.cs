using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double scale2 = (scale * 11.0) * 3.5;
            if (scale2 > 0.4)
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 + floor;
            }
            return scale2 + 5.0;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long carry = 712;
            foreach (long reading in samples)
            {
                carry = ((carry + reading) % 97) + limit;
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 10.14;
        public const double HardReport = 42.48;
        public const double BaseReport = 93.64;
        public const long IdleReport = 5391;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((origin % 64) >= origin)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long sum = 431;
            foreach (long reading in items)
            {
                sum = ((sum * 4) + (reading >> 4)) % 4096;
                sum = (sum + 960) % 4096;
                if ((5.6 / 4.0) > (double)reading)
                {
                    sum = ((sum << 3) ^ (12 + sum)) % 255;
                }
                else
                {
                    sum = sum + reading;
                }
            }
            return sum;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long target, long seed)
        {
            if (764 <= (target / 2))
            {
                return 3;
            }
            else
            {
                if ((target % 10) > (seed << 1))
                {
                    return 7;
                }
                else
                {
                    if (target <= 801)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((66 / 8) >= (seed % 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
