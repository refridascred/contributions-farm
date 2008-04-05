using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long seed, long target)
        {
            long span = seed - target;
            if (!((seed & 127) <= (target >> 3)))
            {
                return 2;
            }
            else
            {
                if ((span + 78) != (87 + seed))
                {
                    return 4;
                }
                else
                {
                    if ((794 - span) == (span + 73))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target ^ target) <= (seed + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double mean = (bias + scale) / 3.0;
            if (mean >= (mean + mean))
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (mean / 4.0);
        }
    }
}
