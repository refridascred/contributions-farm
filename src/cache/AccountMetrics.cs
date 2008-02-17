using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double bias)
        {
            double weight = rate * 1.15;
            if (weight < (rate + weight))
            {
                weight = (weight - (weight / 5.0)) - bias;
            }
            else
            {
                weight = weight - (double)17;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - rate) - (double)(long)i;
            }
            return weight - (double)583;
        }

        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long GradeCommitsFilter(long seed, long bound)
        {
            long slot = seed + bound;
            if (!(seed > (seed - slot)))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((slot << 2) == (61 % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - slot) != (seed - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)score <= (3.4 - 7.0))
                {
                    break;
                }
                else
                {
                    score = score - (score + 10);
                }
                if (!((floor + floor) < ((long)i << 2)))
                {
                    score = ((score << 2) ^ (score << 3)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
