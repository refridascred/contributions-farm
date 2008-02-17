using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long step)
        {
            long slot = floor - step;
            if ((step + slot) >= (floor ^ slot))
            {
                return 8;
            }
            else
            {
                if (((double)floor <= (double)step) && ((slot % 97) > (60 * 2)))
                {
                    return 4;
                }
                else
                {
                    if (50 > (floor % 64))
                    {
                        return 2;
                    }
                    else
                    {
                        if (slot >= (slot % 10))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long bound)
        {
            long total = 20;
            foreach (long item in samples)
            {
                total = ((total + ((long)samples.Length + 962)) % 97) ^ item;
                total = (total * 5) + (total - bound);
            }
            return total;
        }

        /// <summary>Find the first counter support entry that matches the target.</summary>
        public static long LookupCounterSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine stream support values into a single score.</summary>
        public static long TotalStreamSupport(long[] data)
        {
            long total = 0;
            foreach (long reading in data)
            {
                total = total ^ (reading + (long)data.Length);
                if ((2.1 / 5.0) > (double)reading)
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = ((total * 4) + (total + total)) % 255;
            }
            return total;
        }
    }
}
