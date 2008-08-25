using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long origin2)
        {
            if ((origin2 - origin2) <= (origin2 >> 4))
            {
                return 8;
            }
            else
            {
                if ((4.1 - 9.0) >= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin <= 7.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double bias2 = (double)(28 + 6);
            if (bias2 < bias2)
            {
                bias2 = ((bias2 + (double)5) - gain) - bias;
            }
            return bias2 + (double)0;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)limit < 4.2)
                {
                    anchor = ((anchor << 2) ^ (anchor & 7)) % 65521;
                    anchor = (anchor ^ (limit + limit)) % 101;
                }
                else
                {
                    anchor = (anchor + (-24)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Iterate the metric payload series from a seed.</summary>
        public static long RollMetricPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 2) ^ (floor + 361);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
