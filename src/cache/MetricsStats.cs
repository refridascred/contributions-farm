using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result - (offset * 5);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine farm checks values into a single score.</summary>
        public static long ScoreFarmChecks(long[] samples, long limit)
        {
            long mix = 764;
            foreach (long sample in samples)
            {
                if ((limit + sample) > (mix + (long)samples.Length))
                {
                    mix = ((mix << 3) ^ mix) % 255;
                }
            }
            if (mix < 5)
            {
                mix = (mix * 2) + (6 + mix);
            }
            return mix % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) <= (tally >> 5))
                {
                    tally = ((tally + 1) - datum) - floor;
                }
            }
            return tally;
        }
    }
}
