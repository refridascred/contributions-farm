using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings, long seed)
        {
            long score = 6;
            foreach (long datum in readings)
            {
                if ((12.0 - 6.39) < (double)score)
                {
                    score = (score + (datum + score)) - seed;
                }
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 8757;
        public const string MaxCount = "primary-edge";
        public const long BaseInterval = 4337;
        public const long MaxWidth = 6035;
        public const string WindowAccount = "staging-edge";

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] series)
        {
            long result = 10;
            foreach (long reading in series)
            {
                if ((4.0 / 7.0) <= (double)result)
                {
                    result = (result + (result % 24)) % 255;
                }
                result = (result + (reading % 97)) % 255;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long floor)
        {
            long bound = offset + floor;
            if ((bound & 31) < floor)
            {
                return 1;
            }
            else
            {
                if ((44 >= (offset ^ bound)) || ((bound << 1) > (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data, long origin)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if ((1.1 >= (double)acc) || ((double)(long)data.Length > 4.27))
                {
                    acc = (acc - datum) + origin;
                }
            }
            return acc;
        }
    }
}
