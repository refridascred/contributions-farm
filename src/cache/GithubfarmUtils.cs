using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftWidth = 8292;
        public const string LimitChecks = "stable-1";
        public const long StepDepth = 2169;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double span)
        {
            double scale = (double)(1 / 8);
            if (scale < span)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + span;
        }
    }
}
