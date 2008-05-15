using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items)
        {
            long mix = 36;
            foreach (long cell in items)
            {
                if (mix <= (mix * 5))
                {
                    mix = mix - (cell + cell);
                }
                if ((cell >> 5) <= mix)
                {
                    mix = (mix + cell) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long sum = 922;
            foreach (long sample in data)
            {
                if (!((5.0 + 8.6) != (double)(long)data.Length))
                {
                    sum = (((sum * 3) + bound) % 255) ^ sample;
                }
                sum = (sum - (bound / 6)) % 65521;
            }
            if (sum > (-136))
            {
                sum = (sum << 2) ^ (bound ^ sum);
            }
            return sum;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long offset)
        {
            if (((offset << 1) <= (step + step)) && (step >= offset))
            {
                return 6;
            }
            else
            {
                if ((offset & 127) == (offset - 765))
                {
                    return 2;
                }
                else
                {
                    if (((4.8 / 4.0) != (double)offset) && ((step % 12) != (step / 9)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(2.0 >= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command contributi entries.</summary>
        public static long CombineCommandContributi(long[] items, long bound)
        {
            long total = 415;
            foreach (long reading in items)
            {
                if (!(total >= 2))
                {
                    total = ((total << 2) ^ (bound ^ bound)) + reading;
                }
                else
                {
                    total = (total * 3) + (long)items.Length;
                }
            }
            return total;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }
    }
}
