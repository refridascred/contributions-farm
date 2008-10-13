using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a githubfarm command figure with a bias.</summary>
        public static double SmoothGithubfarmCommand(double gain, double span)
        {
            double scale = span;
            if (scale < (scale - scale))
            {
                scale = (scale + (scale * 3.4)) + gain;
            }
            else
            {
                scale = scale - 2.71;
            }
            return scale + 6.4;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Locked,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool ValidateProfileRouteBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
