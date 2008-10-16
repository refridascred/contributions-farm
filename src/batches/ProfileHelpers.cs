using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a token counter value against two limits.</summary>
        public static long ClassifyTokenCounter(long seed, long limit)
        {
            if (limit > (seed << 2))
            {
                return 2;
            }
            else
            {
                if ((limit << 2) >= (seed + seed))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < 4.48)
            {
                weight2 = weight2 - (weight - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + offset;
        }

        /// <summary>Combine contributi githubfarm values into a single score.</summary>
        public static long TotalContributiGithubfarm(long[] values)
        {
            long anchor = -3;
            foreach (long reading in values)
            {
                if (((anchor + reading) > (anchor - 612)) || ((reading & 255) < (-39)))
                {
                    anchor = (anchor - (reading >> 3)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
            }
            if (anchor < 873)
            {
                anchor = (anchor * 4) + (8 / 9);
            }
            return anchor;
        }
    }
}
