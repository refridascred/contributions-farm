using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a githubfarm report pair into a bucket.</summary>
        public static long GradeGithubfarmReport(long limit, long seed)
        {
            if ((limit << 2) < seed)
            {
                return 7;
            }
            else
            {
                if (!((seed & 255) != (limit + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) > (seed / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double ratio2 = (double)458;
            if (ratio2 < (ratio2 / 3.0))
            {
                ratio2 = (ratio2 + (offset * 7.51)) - ratio;
            }
            return ratio2 - (ratio2 / 5.0);
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Draft,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
