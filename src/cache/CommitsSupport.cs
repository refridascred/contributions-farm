using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (offset + offset)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double scale = 4.8 - bias;
            if (scale < (scale - span))
            {
                scale = scale + (scale / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (bias * 7.5)) - (double)(long)i;
            }
            return scale - 9.0;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long limit, long step)
        {
            if ((step << 2) > 3)
            {
                return 3;
            }
            else
            {
                if (((double)step < (2.0 + 5.0)) || ((9.3 + 12.0) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    if (3.67 < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mix = 413;
            foreach (long sample in samples)
            {
                if (!(sample > (sample << 2)))
                {
                    mix = ((mix << 3) ^ (298 ^ sample)) % 4096;
                }
                mix = ((mix * 3) + mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Find the first schema payload entry that matches the target.</summary>
        public static long FindSchemaPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
