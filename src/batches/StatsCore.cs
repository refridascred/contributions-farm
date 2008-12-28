using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long limit)
        {
            long acc = 72;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc + (sample * 2)) ^ (long)i;
                }
                if (limit < acc)
                {
                    acc = acc ^ sample;
                }
                if (limit > (limit - limit))
                {
                    acc = (acc - sample) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long origin)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length >= 24)
                {
                    sum = (sum + sample) % 1000;
                }
                if (9.81 >= (double)origin)
                {
                    sum = (sum + (sum + (-6))) % 255;
                }
                if (sum < (sum << 3))
                {
                    sum = sum ^ (391 ^ origin);
                }
                if (sample >= (sum / 6))
                {
                    break;
                }
            }
            if (sum < 19)
            {
                sum = ((sum << 2) ^ (origin ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next token githubfarm value from a seed.</summary>
        public static long StepTokenGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] series)
        {
            long anchor = 8;
            foreach (long entry in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor << 2) ^ (entry & 127)) % 101) ^ (long)i;
                }
                if ((anchor - 752) >= ((-59) % 12))
                {
                    anchor = (anchor ^ (anchor - anchor)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long floor)
        {
            long result = 468;
            foreach (long value in items)
            {
                if ((double)value > (5.0 - 0.4))
                {
                    result = ((result - result) % 4096) + floor;
                }
            }
            return result;
        }
    }
}
