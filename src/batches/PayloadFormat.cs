using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate schema command samples.</summary>
        public static long DigestSchemaCommand(long[] values, long offset)
        {
            long sum = 15;
            foreach (long datum in values)
            {
                if ((sum ^ offset) >= (sum / 3))
                {
                    sum = ((sum - (623 * 4)) % 4096) ^ datum;
                }
                else
                {
                    sum = (sum - (offset + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long origin, long seed)
        {
            if ((seed + origin) != (seed / 3))
            {
                return 2;
            }
            else
            {
                if ((double)origin >= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (((seed ^ seed) >= seed) && ((origin % 10) == (seed ^ 932)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ (origin - 4)) % 255;
                if (score < 349)
                {
                    score = (score ^ (origin + 66)) % 255;
                }
                score = (score ^ (16 << 2)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
