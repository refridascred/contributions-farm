using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double scale = 7.2;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (2.0 + ratio)) + (double)(long)i) + floor;
            }
            return scale - (double)8;
        }

        /// <summary>Classify a window graph pair into a bucket.</summary>
        public static long BucketWindowGraph(long step, long step2)
        {
            long cur = step - step2;
            if (((5.26 + 2.9) == (double)cur) || ((step << 3) > (cur / 7)))
            {
                return 6;
            }
            else
            {
                if (step2 < (step2 ^ cur))
                {
                    return 8;
                }
                else
                {
                    if (!((step2 - step) != (step2 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 18.36;
        public const string MaxTools = "standard-v2";
        public const long StepTools = 9882;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long step, long offset)
        {
            if (412 < (step % 12))
            {
                return 2;
            }
            else
            {
                if ((17.0 / 6.0) < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((9.58 + 1.6) > (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 <= (step & 1)) && ((step >> 5) >= 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
