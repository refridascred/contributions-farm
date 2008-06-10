using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 3) + (result + seed);
                if (!(((671 / 2) < (long)i) || (48 >= seed)))
                {
                    result = (result ^ (long)i) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Adjust a filter stats reading.</summary>
        public static double AdjustFilterStats(double gain, double span)
        {
            double weight = gain * 4.0;
            if (weight > 9.14)
            {
                weight = weight + weight;
            }
            return weight - (5.06 - span);
        }
    }
}
