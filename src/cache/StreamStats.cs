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

        /// <summary>Fold a list of route payload readings.</summary>
        public static long CombineRoutePayload(long[] readings)
        {
            long sum = 27;
            foreach (long value in readings)
            {
                if ((261 - value) == (256 >> 2))
                {
                    sum = (sum - (value & 15)) % 255;
                }
                else
                {
                    sum = ((sum * 2) + sum) % 97;
                }
            }
            if (sum > 34)
            {
                sum = (sum * 4) + ((-1) - sum);
            }
            return sum;
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
