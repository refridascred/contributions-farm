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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((acc - origin) != (long)i)
                {
                    acc = (acc - (7 + 21)) % 101;
                }
                if ((origin - origin) > ((long)i * 4))
                {
                    acc = (acc << 2) ^ (origin >> 2);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
