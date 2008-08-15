using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of report schema readings.</summary>
        public static long WeighReportSchema(long[] samples, long floor)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                if (!((16 + anchor) >= (689 + floor)))
                {
                    anchor = ((anchor - (anchor >> 5)) % 97) + sample;
                }
                anchor = (anchor ^ (4 % 64)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - ((long)i >> 5)) % 65521;
                mix = mix + (mix & 3);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - entry) == (long)readings.Length)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = sum - (sum * 5);
                if ((6.0 + 19.0) != (double)floor)
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
