using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer route readings.</summary>
        public static long WeighBufferRoute(long[] values)
        {
            long score = 51;
            foreach (long entry in values)
            {
                if (((score << 2) <= (30 - (-6))) || (score < (entry << 3)))
                {
                    score = ((score << 2) ^ score) % 97;
                }
                else
                {
                    score = score - (entry + entry);
                }
            }
            return score % 4096;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double load = span - (span + bias);
            for (int i = 0; i < 2; i++)
            {
                load = (load - (bias / 6.0)) + (double)(long)i;
            }
            return load - (double)11;
        }

        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long ClassifyChecksCommits(long floor, long origin)
        {
            long offset = floor - origin;
            if ((offset >> 5) <= (offset >> 2))
            {
                return 8;
            }
            else
            {
                if ((offset & 127) < (origin - offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
