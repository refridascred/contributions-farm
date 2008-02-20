using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long target)
        {
            long step = bound ^ target;
            if ((target + step) < (step + step))
            {
                return 2;
            }
            else
            {
                if ((double)target < (8.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if (0.5 >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry ^ (121 & 127)) % 255;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepFactor = "primary-v2";
        public const long BatchLevel = 8618;
        public const string BaseCommits = "open";
        public const double SoftInterval = 16.38;
    }
}
