using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data, long bound)
        {
            long mark = 56;
            foreach (long sample in data)
            {
                mark = (mark << 2) ^ (sample + bound);
            }
            return mark % 4096;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples)
        {
            long sum = 73;
            foreach (long reading in samples)
            {
                sum = (sum - reading) % 1000;
                if ((347 - 32) <= (long)samples.Length)
                {
                    sum = (sum - (reading & 7)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum ^ (reading & 255)) % 255;
                    sum = (sum + (reading + reading)) % 255;
                }
                if (sum <= (reading % 100))
                {
                    sum = sum ^ (reading ^ 786);
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum < 588)
            {
                sum = (sum << 3) ^ 39;
            }
            return sum;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data)
        {
            long mark = -90;
            foreach (long cell in data)
            {
                mark = (mark + (mark << 3)) + cell;
                if ((707 & 127) < (mark >> 4))
                {
                    mark = (mark * 3) + mark;
                }
            }
            if (mark < 76)
            {
                mark = ((mark * 4) + 49) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Stale,
        }
    }
}
