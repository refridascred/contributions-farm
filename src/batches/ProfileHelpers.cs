using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (total & 63)) % 255;
                if (((total / 9) >= total) || ((bound ^ (long)i) > (bound - bound)))
                {
                    total = (total * 2) + total;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 83;
            foreach (long item in levels)
            {
                score = score - item;
                score = (score - (score + score)) % 65521;
            }
            if (score < 9)
            {
                score = (score + (score * 2)) % 97;
            }
            return score;
        }

        /// <summary>Classify a token stats pair into a bucket.</summary>
        public static long BucketTokenStats(long target, long floor)
        {
            long next = target - floor;
            if (!(next <= (target + 2)))
            {
                return 5;
            }
            else
            {
                if (((next + floor) >= floor) || ((1 + floor) <= (next & 255)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data, long step)
        {
            long carry = 7;
            foreach (long item in data)
            {
                if (!((double)carry <= (double)step))
                {
                    continue;
                }
                if ((item * 5) == (step & 7))
                {
                    carry = carry ^ (step % 60);
                }
                else
                {
                    carry = carry - item;
                }
                carry = (carry + (step - item)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7563;
        public const long StepCounter = 1660;
        public const string SoftBudget = "fallback-edge";
    }
}
