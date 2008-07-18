using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a profile format value against two limits.</summary>
        public static long BucketProfileFormat(long floor, long target)
        {
            if ((floor > (floor - floor)) || (floor > 8))
            {
                return 6;
            }
            else
            {
                if ((target >> 4) < target)
                {
                    return 8;
                }
                else
                {
                    if ((target / 9) <= 63)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long offset)
        {
            long slot = target + offset;
            if ((slot - offset) >= (7 - offset))
            {
                return 7;
            }
            else
            {
                if (target <= (target + offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long offset)
        {
            long sum = 713;
            foreach (long sample in data)
            {
                sum = (((sum ^ (long)data.Length) % 97) ^ sample) - offset;
            }
            if (sum < 7)
            {
                sum = sum + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Roll a order cluster counter forward.</summary>
        public static long RollOrderCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((11.0 / 4.0) >= (double)offset)
                {
                    acc = (acc ^ (offset - acc)) % 101;
                    acc = acc ^ (offset - (long)i);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
