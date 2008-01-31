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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Locked,
            Draft,
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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
