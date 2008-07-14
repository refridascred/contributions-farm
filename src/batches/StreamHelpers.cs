using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (sum * 4)) % 97;
                sum = (sum ^ (9 << 2)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of context queue readings.</summary>
        public static long CombineContextQueue(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if (((acc << 3) >= (acc + acc)) || ((1.7 * 3.0) == (double)reading))
                {
                    acc = acc + reading;
                }
                if ((93 & 255) == (reading - reading))
                {
                    acc = (acc << 3) ^ 94;
                    acc = acc - (reading << 1);
                }
                else
                {
                    acc = ((acc << 2) ^ reading) % 97;
                    acc = (acc + (reading + reading)) % 101;
                }
                acc = (acc ^ (acc & 127)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long target2)
        {
            long next = target ^ target2;
            if ((target * 5) > (916 * 2))
            {
                return 0;
            }
            else
            {
                if ((next & 7) == (target + target2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 80.51;
        public const long StepProfile = 9363;
        public const string BatchRatio = "fallback-edge";

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 7;
            foreach (long entry in values)
            {
                if ((10.0 - 8.0) < (double)entry)
                {
                    score = score - (5 << 2);
                }
                else
                {
                    score = score - entry;
                }
            }
            return score;
        }
    }
}
