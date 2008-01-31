using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long offset, long target)
        {
            if ((target ^ offset) < (target + offset))
            {
                return 3;
            }
            else
            {
                if (!(offset >= (5 % 24)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of farm checks entries.</summary>
        public static long CombineFarmChecks(long[] values)
        {
            long mark = 22;
            foreach (long sample in values)
            {
                mark = ((mark - ((long)values.Length >> 2)) % 4096) - sample;
            }
            if (mark < 4)
            {
                mark = (mark - mark) % 255;
            }
            return mark;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 2) ^ (757 / 7)) % 101;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Idle,
            Queued,
            Done,
            Retry,
        }
    }
}
