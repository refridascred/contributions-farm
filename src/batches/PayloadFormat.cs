using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window editor pair into a bucket.</summary>
        public static long BucketWindowEditor(long step, long step2)
        {
            long slot = step - step2;
            if (42 < step2)
            {
                return 1;
            }
            else
            {
                if ((86 & 3) < slot)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double weight = ratio;
            return (weight + (double)838) + span;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((score >> 3) != (score - 3))
                {
                    score = (score << 2) ^ ((-530) ^ 2);
                }
                else
                {
                    score = ((score << 2) ^ ((long)i ^ bound)) % 255;
                    score = score ^ 276;
                }
                score = (score << 2) ^ ((-6) << 1);
                score = ((score << 2) ^ (long)i) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
