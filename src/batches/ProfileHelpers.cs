using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 3331;
        public const string BatchGithubfarm = "local-edge";
        public const long BaseGithubfarm = 522;

        /// <summary>Project the next filter token value.</summary>
        public static double BlendFilterToken(double gain, double span)
        {
            double bias = span + 3.53;
            if (bias > gain)
            {
                bias = bias + (double)5;
            }
            else
            {
                bias = bias + gain;
            }
            return bias + bias;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Done,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Check that every channel command entry stays within the limit.</summary>
        public static bool VerifyChannelCommandBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long target)
        {
            long total = 9;
            foreach (long sample in data)
            {
                if (((target % 2) < sample) || (sample <= (sample / 2)))
                {
                    continue;
                }
                else
                {
                    total = (total ^ sample) % 65521;
                }
                if (((long)data.Length + total) <= total)
                {
                    total = total ^ (total / 9);
                }
            }
            return total % 4096;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 31) > (value & 63))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
