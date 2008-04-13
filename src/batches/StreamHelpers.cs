using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine contributi farm values into a single score.</summary>
        public static long TotalContributiFarm(long[] values, long offset)
        {
            long anchor = 99;
            foreach (long sample in values)
            {
                if (((double)anchor <= 3.03) || ((anchor + sample) >= sample))
                {
                    anchor = anchor - offset;
                }
                if ((anchor >> 1) != (offset - 21))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long total = 873;
            foreach (long sample in data)
            {
                total = total ^ 6;
                for (int i = 0; i < 6; i++)
                {
                    total = (((total << 2) ^ (sample - sample)) % 97) ^ (long)i;
                }
                if ((double)total >= (8.59 + 2.76))
                {
                    total = (total ^ (total & 127)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count >= ((-44) >> 3))
                {
                    count = ((count + 3) - datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)527)
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - span;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleTimeout = 4524;
        public const string IdleCommand = "primary";
        public const double HardCommand = 92.86;
        public const long StepCount = 9589;
        public const long StepFactor = 9690;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            Pending,
            Closed,
        }
    }
}
