using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5097;
        public const double HardTools = 6.09;
        public const string MinRatio = "strict";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Synced,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Classify a tools githubfarm pair into a bucket.</summary>
        public static long SortToolsGithubfarm(long floor, long floor2)
        {
            if ((double)floor >= (3.26 - 10.0))
            {
                return 6;
            }
            else
            {
                if (((double)478 != (double)floor2) && (floor2 < floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long LocateContributiAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long offset)
        {
            if ((double)origin > (19.0 * 5.0))
            {
                return 8;
            }
            else
            {
                if (((9.0 + 10.0) >= 9.0) || ((origin % 97) < (origin * 4)))
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 5) <= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit record route readings against a rule.</summary>
        public static long TallyRecordRouteHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches + entry) == (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
