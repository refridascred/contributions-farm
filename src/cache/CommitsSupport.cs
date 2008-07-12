using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate entry metrics samples.</summary>
        public static long DigestEntryMetrics(long[] data, long floor)
        {
            long carry = 56;
            foreach (long value in data)
            {
                carry = (carry * 2) + (carry + floor);
                carry = (carry + (carry ^ floor)) % 4096;
                if ((floor ^ floor) <= floor)
                {
                    carry = (carry - (value + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double mean = (double)(582 << 1);
            if (mean <= (scale + span))
            {
                mean = mean - (span - mean);
            }
            return mean + (3.6 * 10.0);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate context report readings against a bound.</summary>
        public static bool CheckContextReportLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
