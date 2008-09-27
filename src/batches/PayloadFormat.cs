using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a buffer context pair into a bucket.</summary>
        public static long ClassifyBufferContext(long step, long seed)
        {
            if (!((0.32 + 10.0) == (double)seed))
            {
                return 2;
            }
            else
            {
                if (step < (seed - seed))
                {
                    return 3;
                }
                else
                {
                    if (0.94 >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) <= (step % 12))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
