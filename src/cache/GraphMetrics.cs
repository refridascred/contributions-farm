using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)sum != (16.0 - 6.0))
                {
                    sum = (sum + ((long)i * 5)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long step)
        {
            if (!((target >> 5) < step))
            {
                return 8;
            }
            else
            {
                if ((6 + target) <= (step - step))
                {
                    return 6;
                }
                else
                {
                    if (!((target ^ step) == (step << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((score & 15) <= (score << 1))
                {
                    score = (score << 2) ^ (score - seed);
                    score = score ^ (score & 3);
                    break;
                }
                if (!((score % 60) <= ((long)i + score)))
                {
                    score = (score + (seed >> 1)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
