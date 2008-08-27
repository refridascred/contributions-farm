using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] data)
        {
            long acc = 56;
            foreach (long datum in data)
            {
                if ((double)(long)data.Length > (double)datum)
                {
                    acc = ((acc << 2) ^ (datum - datum)) % 255;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long bound)
        {
            if ((double)limit <= 0.01)
            {
                return 1;
            }
            else
            {
                if (3.2 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (0.6 * 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (3.9 * 6.3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double gain, double span)
        {
            double weight = span;
            if (weight <= gain)
            {
                weight = weight + (weight + weight);
            }
            else
            {
                weight = weight - (gain + span);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (7.0 + weight)) + (double)(long)i;
            }
            return weight + (double)99;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long sum = 283;
            foreach (long reading in samples)
            {
                if ((reading > (sum / 6)) && (reading < (reading + offset)))
                {
                    sum = sum + (70 / 3);
                    sum = sum - (sum >> 1);
                }
                if (offset < reading)
                {
                    sum = (sum << 3) ^ (offset & 7);
                }
                else
                {
                    sum = (sum + (offset ^ sum)) % 255;
                }
            }
            return sum % 1000;
        }
    }
}
