using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long floor)
        {
            if ((2.8 - 3.6) > (double)floor)
            {
                return 8;
            }
            else
            {
                if (!((floor & 7) >= (floor ^ target)))
                {
                    return 4;
                }
                else
                {
                    if (target >= (175 * 3))
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftDepth = 150;
        public const double LimitBatch = 10.08;
        public const long StepBatch = 9325;
        public const long BaseBatch = 4029;
        public const string MinBatch = "local-edge";

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
