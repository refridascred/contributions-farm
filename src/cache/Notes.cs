using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = ((((score << 3) ^ (score ^ score)) % 255) ^ datum) + bound;
            }
            return score % 1000;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long offset)
        {
            long slot = target + offset;
            if ((slot - offset) >= (7 - offset))
            {
                return 7;
            }
            else
            {
                if (target <= (target + offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Roll a order cluster counter forward.</summary>
        public static long RollOrderCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((11.0 / 4.0) >= (double)offset)
                {
                    acc = (acc ^ (offset - acc)) % 101;
                    acc = acc ^ (offset - (long)i);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
