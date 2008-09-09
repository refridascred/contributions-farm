using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long seed)
        {
            if ((double)seed > (double)906)
            {
                return 1;
            }
            else
            {
                if (((seed ^ target) == (seed * 3)) || ((double)seed < (17.0 + 7.9)))
                {
                    return 5;
                }
                else
                {
                    if (((9.75 - 4.36) >= (double)target) && ((double)seed >= (double)646))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer context sample.</summary>
        public static long SeekBufferContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) < 30)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
