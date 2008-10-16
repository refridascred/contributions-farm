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

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Locked,
            New,
            Draft,
            Ready,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Check that every command notes entry stays within the limit.</summary>
        public static bool CheckCommandNotesLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            if (((double)origin >= 18.0) && ((11.0 + 10.0) > (double)origin))
            {
                return 3;
            }
            else
            {
                if (origin > (97 + limit))
                {
                    return 2;
                }
                else
                {
                    if ((origin % 2) <= (limit << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
