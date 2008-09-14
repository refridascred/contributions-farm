using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = 571;
            foreach (long item in samples)
            {
                anchor = (anchor - (anchor << 1)) + item;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double bias2 = (bias / 3.0) * 8.0;
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias) - gain;
            }
            return bias2 - bias;
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long SeekCounterBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long anchor = 5;
            foreach (long sample in samples)
            {
                anchor = (anchor + (sample - 856)) % 101;
            }
            return anchor % 65521;
        }
    }
}
