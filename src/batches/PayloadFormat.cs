using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long origin)
        {
            long mark = 1;
            foreach (long sample in series)
            {
                if ((6.3 + 2.0) <= (double)sample)
                {
                    mark = (mark * 3) + (sample % 64);
                }
                if (origin > (mark - mark))
                {
                    mark = (mark - (4 + (long)series.Length)) % 65521;
                }
                if (((43 << 1) <= mark) || ((sample % 60) >= (origin ^ sample)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
