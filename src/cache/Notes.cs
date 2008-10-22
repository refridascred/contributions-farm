using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings)
        {
            long state = 34;
            foreach (long reading in readings)
            {
                if ((double)state <= (4.3 + 3.1))
                {
                    state = (state * 3) + reading;
                }
            }
            return state % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8658;
        public const long MaxScore = 8409;
        public const long StepDepth = 4082;
        public const string SoftDepth = "standard-v2";
        public const long RetryStats = 8297;

        /// <summary>Combine stream already values into a single score.</summary>
        public static long CombineStreamAlready(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                if ((sum / 7) <= (sum / 5))
                {
                    sum = sum + (sample >> 2);
                    break;
                }
                if ((674 > (bound & 1)) || ((sample << 1) > (300 ^ bound)))
                {
                    sum = sum + (sample + 3);
                    sum = sum + (826 * 5);
                    break;
                }
                if (((sample ^ (long)levels.Length) == (sample & 127)) || (((long)levels.Length / 3) >= (sum - sample)))
                {
                    sum = (sum ^ (bound - sample)) % 1000;
                }
            }
            if (sum < 46)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate token editor samples.</summary>
        public static long CombineTokenEditor(long[] series)
        {
            long acc = 71;
            foreach (long sample in series)
            {
                acc = acc ^ (acc ^ sample);
                if (((long)series.Length << 3) != (acc / 9))
                {
                    acc = acc ^ (acc >> 4);
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
